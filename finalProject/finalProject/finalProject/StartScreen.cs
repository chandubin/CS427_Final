using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using finalProject;
using Microsoft.Xna.Framework.Input;

namespace finalProject
{
	class StartScreen : GameScreen
	{
        
		Texture2D image;
		Rectangle imageRectangle;
        List<VisibleGameEntity> entities=new List<VisibleGameEntity>();
        int nEntities=0;
        Rectangle destination1, sourceRectangle1;
        Rectangle destination2, sourceRectangle2;
        Texture2D bar1;
        Texture2D bar2;
        
        protected override void LoadContent()
        {
            
            MenuDialog menu = new MenuDialog(@"UserInterface/Button/Background",1 ,50, 50, 0, 0);
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/play", 1, 79, 474, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/resume", 1, 270, 473, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/score", 1, 455, 478, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/option", 1, 640, 472, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/help", 1, 815, 475, 0, 0));
            entities.Add(menu);
            nEntities++;
            bar1 = Global.Content.Load<Texture2D>(@"UserInterface/Button/optionBar");
            bar2= Global.Content.Load<Texture2D>(@"UserInterface/Button/optionBar");
            
            sourceRectangle1 = new Rectangle(0, 0, 217, 11);

            //destination2 = new Rectangle(395, 245, 217, 11);
            sourceRectangle2 = new Rectangle(0, 0, 217, 11);
            base.LoadContent();
        }
		public StartScreen(Game game, 
		SpriteBatch spriteBatch, 
		SpriteFont spriteFont, 
		Texture2D image)
			: base(game, spriteBatch)
		{

            string[] menuItems = { "New Game" ,"End Game" };
			this.image = image;
			imageRectangle = new Rectangle(
				0,
				0,
				Game.Window.ClientBounds.Width,
				Game.Window.ClientBounds.Height);
            game.IsMouseVisible = true;

            LoadContent();
       
		}
              

		public override void Update(GameTime gameTime)
		{
           sourceRectangle1.Width = (int)(217 * ((float)(Global.sound) / 100));
            sourceRectangle2.Width = (int)(217 * (float)(Global.music) / 100);
            if (nEntities >= 2)
            {
                if(Global.grid) ((MenuDialog)entities[2]).Circle(0);
                else ((MenuDialog)entities[2]).Circle(-1);
            }
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Pressed)
            {
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx != -1 && entities[idx] is MenuDialog)
                {
                    ((MenuDialog)entities[idx]).Circle(((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y));
                }
              
            }
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Released && Global.mouseHelper.PreviousState.LeftButton == ButtonState.Pressed)
            {
                int count = ((MenuDialog)entities[0]).item.Count;
                for (int i = 0; i < count; i++)
                {
                    ((MenuDialog)entities[0]).item[i]._MainModel.Select(false);
                }
                if (nEntities >= 2)
                {
                    count = ((MenuDialog)entities[1]).item.Count;
                    for (int i = 0; i < count; i++)
                    {
                        ((MenuDialog)entities[1]).item[i]._MainModel.Select(false);
                    }
                }
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx != -1 && entities[idx] is MenuDialog&&nEntities==1)
                {
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 0)
                    {
                        Global.currentScreen = "selectionMap";
                    }
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 4)
                    {
                        Global.currentScreen = "helpScreen";
                    }
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 3)
                    {
                        MenuDialog menu = new MenuDialog(@"UserInterface/title_option", 1, 500, 250, 0, 0);
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_square", 1, 374, 205, 0, 0));
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_square", 1, 374, 250, 0, 0));
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_square", 1, 635, 205, 0, 0));
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_square", 1, 635, 250, 0, 0));
                        entities.Add(menu);     
                        MenuDialog menu2 = new MenuDialog(@"UserInterface/Button/Background", 1, 500, 250, 0, 0);
                        menu2.item.Add(new MenuDialogItem(@"UserInterface/Button/button_check", 1, 445, 280, 0, 0));
                        entities.Add(menu2);
                        MenuDialog menu3 = new MenuDialog(@"UserInterface/Button/Background", 1, 500, 250, 0, 0);
                        menu3.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_ok", 1, 495, 335, 0, 0));
                        entities.Add(menu3);
                        nEntities+=3;
                    }
                }

                if (idx != -1 && entities[idx] is MenuDialog && nEntities >= 2)
                {
                    if (idx == 2)
                    {
                        if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 0)
                        {
                            if (Global.grid) Global.grid = false;
                            else Global.grid = true;

                        }
                    }
                    if (idx == 3)
                    {
                        entities.RemoveRange(1, 3);
                        nEntities -= 3;
                    }
                    if (idx == 1)
                    {
                        switch (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y))
                        {
                            case 2:
                            {
                                Global.sound += 10;
                                if (Global.sound >= 100) Global.sound = 100;
                                break;
                            }
                            case 0:
                            {
                                Global.sound -= 10;
                                if (Global.sound <= 0) Global.sound = 0;
                                break;
                            }
                            case 3:
                            {
                                Global.music += 10;
                                if (Global.music >= 100) Global.music = 100;
                                break;
                            }
                            case 1:
                            {
                                Global.music -= 10;
                                if (Global.music<=0) Global.music = 0;
                                break;
                            }
                        }
                    }
                }
                
            }

            
            
            Global.UpdateAllInvisibleEntities(gameTime);
            base.Update(gameTime);

		}

		public override void Draw(GameTime gameTime)
		{
            spriteBatch.Begin();
            spriteBatch.Draw(image, imageRectangle, Color.White);
            spriteBatch.End();
            spriteBatch.Begin();
            for (int i = 0; i < nEntities; i++)
            {
                entities[i].Draw(gameTime,spriteBatch);

            }
            spriteBatch.End();
            if (nEntities > 1)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(bar1, new Vector2(395,199), sourceRectangle1, Color.White);
               spriteBatch.Draw(bar2, new Vector2(395,245),sourceRectangle2, Color.White);
                spriteBatch.End();
            }
			base.Draw(gameTime);
		}
     
        private int GetSelectSpriteIndex(float X, float Y)
        {
           if (nEntities >= 2)
            {
                for (int i = 1; i < nEntities; i++)
                {
                    if (entities[i].IsSelected(X, Y) != -1) return i;
                   
                }
                return -1;
            }
           if (nEntities == 1)
           {
               if (entities[0].IsSelected(X, Y) != -1) return 0;
               else return -1;
           }
           else return -1;
        }
     
	}
}

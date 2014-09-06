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
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Pressed)
            {
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx != -1 && entities[idx] is MenuDialog)
                {
                    ((MenuDialog)entities[idx]).Circle(((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y));
                }
              
            }
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Released && Global.mouseHelper.PreviousState.LeftButton == ButtonState.Pressed&& entities[0] is MenuDialog)
            {
                int count = ((MenuDialog)entities[0]).item.Count;
                for (int i = 0; i < count; i++)
                {
                    ((MenuDialog)entities[0]).item[i]._MainModel.Select(false);
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
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_check", 1, 445, 280, 0, 0));
                        menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_option_ok", 1, 495, 335, 0, 0));
                        entities.Add(menu);
                        nEntities++;
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
			base.Draw(gameTime);
		}
     
        private int GetSelectSpriteIndex(float X, float Y)
        {
           if (nEntities == 2)
            {
                if (entities[1].IsSelected(X,Y)!=-1) return 1;
                else return -1;
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

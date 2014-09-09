using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using finalProject;

namespace ScreenManager
{
    class SelectionMapScreen : GameScreen
    {
      
        Texture2D image;
        Rectangle imageRectangle;
        SpriteFont spriteFont;
        List<VisibleGameEntity> entities=new List<VisibleGameEntity>();
        int nEntities = 0;
        public SelectionMapScreen(Game game, SpriteBatch spriteBatch, Texture2D image)
            : base(game, spriteBatch)
        {
            this.image = image;
            imageRectangle = new Rectangle(
                0,
                0,
                Game.Window.ClientBounds.Width,
                Game.Window.ClientBounds.Height);
            LoadContent();
        }
        protected override void LoadContent()
        {
            MenuDialog menu = new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/start", 1, 480, 505, 0, 0));

            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_level_easy", 1, 152, 334, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_level_medium", 1, 328, 333, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_level_hard", 1, 520, 338, 0, 0));

            MenuDialog menu2 = new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            menu2.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_square", 1, 915, 35, 0, 0));
            menu2.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_mode", 1, 745, 245, 0, 0));
            menu2.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_mode", 1, 745, 294, 0, 0));
            menu2.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_mode", 1, 745, 324, 0, 0));

            entities.Add(menu);
            entities.Add(menu2);
            nEntities+=2;
            spriteFont = game.Content.Load<SpriteFont>(@"UserInterface\menufont");
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            ((MenuDialog)entities[0]).Circle(Global.level+1);
            ((MenuDialog)entities[1]).Circle(Global.mode+1);
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Pressed)
            {
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx != -1 && entities[idx] is MenuDialog)
                {
                    int t = ((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y);
                    if (idx == 0)
                    {

                        switch (t)
                        {
                            case 0:
                                {
                                    ((MenuDialog)entities[idx]).Select(t);
                                    break;
                                }
                            case 1:
                            case 2:
                            case 3:
                                {
                                    Global.level = t - 1;
                                    ((MenuDialog)entities[idx]).Circle(t);
                                    break;
                                 }
                        }
                    }
                    if (idx == 1)
                    {
                        Global.mode = t-1;
                        ((MenuDialog)entities[idx]).Circle(t);
                        
                    }
                }

            }
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Released && Global.mouseHelper.PreviousState.LeftButton == ButtonState.Pressed && entities[0] is MenuDialog)
            {
                //int count = ((MenuDialog)entities[0]).item.Count;
                //for (int i = 0; i < count; i++)
                //{
                //    ((MenuDialog)entities[0]).item[i]._MainModel.Select(false);
                //}
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx == 1 && entities[idx] is MenuDialog)
                {
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 0)
                    {
                        Global.currentScreen = "startScreen";
                        reset();
                    }
                }
                if (idx == 0 && entities[idx] is MenuDialog)
                {
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 0)
                    {
                        Global.currentScreen = "ingameScreen";
                        reset();
                    }
                }


            }

            Global.UpdateAllInvisibleEntities(gameTime);
            base.Update(gameTime);
     
        }

        private void reset()
        {
            Global.level = 0;
            Global.mode = 0;
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, imageRectangle, Color.White);
            for (int i = 0; i < nEntities; i++)
            {
                entities[i].Draw(gameTime, spriteBatch);

            }
            spriteBatch.DrawString(spriteFont, "Classic", new Vector2(700, 238), Color.White);
            spriteBatch.DrawString(spriteFont, "Extended", new Vector2(700, 284), Color.DarkKhaki);
            spriteBatch.DrawString(spriteFont, "Endless", new Vector2(700, 325), Color.DarkKhaki);
            spriteBatch.End();
            base.Draw(gameTime);
        }
        private int GetSelectSpriteIndex(float X, float Y)
        {
            int idx = -1;
            for (int i = 0; i < nEntities; i++)
            {
                if (entities[i].IsSelected(X, Y) != -1)
                    idx = i;

            }
            return idx;
        }
    }
}

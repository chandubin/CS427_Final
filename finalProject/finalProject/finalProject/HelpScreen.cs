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
    class HelpScreen : GameScreen
    {
        KeyboardState keyboardState;
        Texture2D image;
        Rectangle imageRectangle;
        MenuDialog menu;
        List<VisibleGameEntity> entities = new List<VisibleGameEntity>();
        int nEntities=0;
        public HelpScreen(Game game, SpriteBatch spriteBatch, Texture2D image)
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
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_square_help", 1, 922, 31, 0, 0));
            
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_vertical", 1, 59, 294, 0, 0));
            menu.item.Add(new MenuDialogItem(@"UserInterface/Button/button_selection_vertical", 1, 892, 294, 0, 0));
            entities.Add(menu);
            nEntities++;
            base.LoadContent();
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
            if (Global.mouseHelper.CurrentState.LeftButton == ButtonState.Released && Global.mouseHelper.PreviousState.LeftButton == ButtonState.Pressed && entities[0] is MenuDialog)
            {
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx == 0 && entities[idx] is MenuDialog)
                {
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 0)
                    {
                        Global.currentScreen = "startScreen";
                        Global.helpState = 1;
                        
                    }
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 1)
                    {
                        if (Global.helpState == 1)
                        {
                            Global.currentScreen = "startScreen";
                            Global.helpState = 1;
                        }
                        else Global.helpState--;

                    }
                    if (((MenuDialog)entities[idx]).IsSelected(pos.X, pos.Y) == 2)
                    {
                        if (Global.helpState == 3)
                        {
                            Global.currentScreen = "startScreen";
                            Global.helpState = 1;
                        }
                        else Global.helpState++;
                    }
                    reset();
                }
                switch (Global.helpState)
                {
                    case 1:{
                        image = game.Content.Load<Texture2D>(@"UserInterface\help1");    
                        break;
                          }
                    case 2:
                        {
                            image = game.Content.Load<Texture2D>(@"UserInterface\help2");    
                            break;
                        }
                    case 3:{
                        image = game.Content.Load<Texture2D>(@"UserInterface\help3");    
                        break;
                    }
                }
            }
            Global.UpdateAllInvisibleEntities(gameTime);
            base.Update(gameTime);

            
        }

        private void reset()
        {
            ((MenuDialog)entities[0]).Circle(-1);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, imageRectangle, Color.White);

            for (int i = 0; i < nEntities; i++)
            {
                entities[i].Draw(gameTime, spriteBatch);

            }
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

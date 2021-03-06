﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using finalProject;

namespace finalProject
{
    class WelcomeScreen : GameScreen
    {
      
        Texture2D image;
        Rectangle imageRectangle;
        public WelcomeScreen(Game game,
        SpriteBatch spriteBatch,
       
        Texture2D image)
            : base(game, spriteBatch)
        {
            
            this.image = image;
            imageRectangle = new Rectangle(
                0,
                0,
                Game.Window.ClientBounds.Width,
                Game.Window.ClientBounds.Height);

        }



        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, imageRectangle, Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

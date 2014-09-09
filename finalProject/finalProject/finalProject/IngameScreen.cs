using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class IngameScreen : GameScreen
    {
        KeyboardState keyboardState;
		Texture2D image;
		Rectangle imageRectangle;
        List<VisibleGameEntity> entities = new List<VisibleGameEntity>();
        int nEntities = 0;
		public IngameScreen(Game game, SpriteBatch spriteBatch, Texture2D image, string gameMode, string gameDifficulty)
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

			keyboardState = Keyboard.GetState();

			if (keyboardState.IsKeyDown(Keys.Escape))
				game.Exit();
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
    }
}

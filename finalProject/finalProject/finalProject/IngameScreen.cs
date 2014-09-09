using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using finalProject;

namespace ScreenManager
{
    public class IngameScreen : GameScreen
    {
        KeyboardState keyboardState;
		Texture2D image;
		Rectangle imageRectangle;
        List<VisibleGameEntity> entities = new List<VisibleGameEntity>();
        int nEntities = 0;
        TileMap map=new TileMap();
        int squaresAcross = 27;
        int squaresDown = 21;
		public IngameScreen(Game game, SpriteBatch spriteBatch, Texture2D image)
			: base(game, spriteBatch)
		{
			this.image = image;
			imageRectangle = new Rectangle(
				0,
				0,
				1024,
				683);
            
            LoadContent();
		}
        protected override void LoadContent()
        {
            Tile.TileSetTexture = game.Content.Load<Texture2D>(@"Map\part1_tileset");
            base.LoadContent();
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
            Vector2 firstSquare = new Vector2(0, 0);
            int firstX = (int)firstSquare.X;
            int firstY = (int)firstSquare.Y;

            Vector2 squareOffset = new Vector2(0, 0);
            int offsetX = (int)squareOffset.X;
            int offsetY = (int)squareOffset.Y;

            for (int y = 0; y < squaresDown; y++)
            {
                for (int x = 0; x < squaresAcross; x++)
                {
                    spriteBatch.Draw(
                        Tile.TileSetTexture,
                        new Rectangle((x * 45) - offsetX, (y * 45) - offsetY, 45, 45),
                        Tile.GetSourceRectangle(map.Rows[y + firstY].Columns[x + firstX].TileID),
                        Color.White);
                }
            }

            for (int i = 0; i < nEntities; i++)
            {
                entities[i].Draw(gameTime, spriteBatch);

            }
            spriteBatch.End();
			base.Draw(gameTime);

		}
    }
}

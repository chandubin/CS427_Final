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
        bool playing = true, playingFast = false;
        bool displayingConfig = false;
        MenuDialog play,fast,config,icon;
        int score = 0, money = 15, blood = 20,round=0;
        SpriteFont font,font2;
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
            play=new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            play.item.Add(new MenuDialogItem(@"UserInterface/Button/hud_play", 1, 70, 630, 0, 0));
            entities.Add(play);
            fast = new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            fast.item.Add(new MenuDialogItem(@"UserInterface/Button/hud_fast", 1, 140, 630, 0, 0));
            entities.Add(fast);
            config = new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            config.item.Add(new MenuDialogItem(@"UserInterface/Button/hud_config", 1, 220, 630, 0, 0));
            entities.Add(config);
            
            icon = new MenuDialog(@"UserInterface/Button/Background", 1, 50, 50, 0, 0);
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/icon_gatling_tower", 1, 700, 630, 0, 0));
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/icon_goo_tower", 1, 790, 630, 0, 0));
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/icon_missile_tower", 1, 880, 630, 0, 0));
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/icon_lightning_tower", 1, 970, 630, 0, 0));
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/hud_money", 1, 30, 30, 0, 0));
            icon.item.Add(new MenuDialogItem(@"UserInterface/icon/hud_health", 1, 970, 30, 0, 0));
            //for (int i = 0; i < 4; i++)
            //{
            //    icon.item[i].Disable(true);
            //}
            entities.Add(icon);
            nEntities += 4;
            font = Global.Content.Load<SpriteFont>(@"UserInterface\menufont2");
            font2 = Global.Content.Load<SpriteFont>(@"UserInterface\menufont3");
            base.LoadContent();
        }

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
            if (Global.mouseHelper.IsMouseLeftButtonClicked())
            {
                Vector2 pos = Global.mouseHelper.GetMousePosition();
                int idx = GetSelectSpriteIndex(pos.X, pos.Y);
                if (idx != -1 && entities[idx] is MenuDialog)
                {
                       switch (idx)
                        {
                            case 0:
                                {
                                    if (playing)
                                    {
                                        ((MenuDialog)entities[idx]).Select(0);
                                        playing = false;
                                    }
                                    else
                                    {
                                        ((MenuDialog)entities[idx]).Select(-1);
                                        playing = true;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (!playingFast)
                                    {
                                        ((MenuDialog)entities[idx]).Select(0);
                                        playingFast = true;
                                    }
                                    else
                                    {
                                        ((MenuDialog)entities[idx]).Select(-1);
                                        playingFast = false;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    displayingConfig = true;

                                    break;
                                }
        
                        }
                    }
                    
                

            }
            Global.UpdateAllInvisibleEntities(gameTime);
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
            
            
            spriteBatch.DrawString(font, "$5",new Vector2(703,645),Color.Black);
            spriteBatch.DrawString(font, "$10", new Vector2(790, 645), Color.Black);
            spriteBatch.DrawString(font, "$20", new Vector2(879, 645), Color.Black);
            spriteBatch.DrawString(font, "$70", new Vector2(969, 645), Color.Black);
            spriteBatch.DrawString(font2, money.ToString(), new Vector2(50, 10), Color.Yellow);
            spriteBatch.DrawString(font2, score.ToString(), new Vector2(500, 7), Color.Yellow);
            spriteBatch.DrawString(font2, "Round "+score.ToString(), new Vector2(470, 35), Color.Yellow);
            spriteBatch.DrawString(font2, blood.ToString(), new Vector2(910, 10), Color.Yellow);
            spriteBatch.End();

			base.Draw(gameTime);

		}
        private int GetSelectSpriteIndex(float X, float Y)
        {
            int idx = -1;
            if (displayingConfig)
                return idx;
            for (int i = 0; i < nEntities; i++)
            {
                if (entities[i].IsSelected(X, Y) != -1)
                    idx = i;

            }
            return idx;
        }
    }
}

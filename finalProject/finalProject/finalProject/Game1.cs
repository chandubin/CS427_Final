using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ScreenManager;

namespace finalProject
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 540;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;

        GameScreen activeScreen;
        StartScreen startScreen;
        ActionScreen actionScreen;
        WelcomeScreen welcomeScreen;
        SelectionMapScreen selectionMapScreen;
        HelpScreen helpScreen;
        IngameScreen ingameScreen;
        //MenuComponent menuComponent;

        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Content.RootDirectory=@"Content";
            Global.Content = Content;
            startScreen = new StartScreen(
                this,
                spriteBatch,
                Content.Load<SpriteFont>(@"UserInterface\menufont"),

                Content.Load<Texture2D>(@"UserInterface\title_screen_wide"));
            
            Components.Add(startScreen);
            startScreen.Hide();

            actionScreen = new ActionScreen(
                this,
                spriteBatch,
                Content.Load<Texture2D>(@"UserInterface\title_screen_wide"));
            
            Components.Add(actionScreen);
            actionScreen.Hide();

            
            selectionMapScreen = new SelectionMapScreen(
                this,
                spriteBatch,
                Content.Load<Texture2D>(@"SelectionMap\map_selection"));

            Components.Add(selectionMapScreen);
            selectionMapScreen.Hide();

            welcomeScreen = new WelcomeScreen(
                this,
                spriteBatch,
                Content.Load<Texture2D>(@"UserInterface\splash"));

            Components.Add(welcomeScreen);
            welcomeScreen.Hide();

            helpScreen = new HelpScreen(
                this,
                spriteBatch,
                Content.Load<Texture2D>(@"UserInterface\help1"));

            Components.Add(helpScreen);
            helpScreen.Hide();


            activeScreen = welcomeScreen;
            activeScreen.Show();

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            activeScreen.Hide();   
            switch (Global.currentScreen)
            {
                case "welcomeScreen":
                    {
                        activeScreen = welcomeScreen;
                        break;
                    }
                case "startScreen":
                    {
                        activeScreen = startScreen;
                        break;
                    }
                case "selectionMap":
                    {
                        activeScreen = selectionMapScreen;
                        break;
                    }
                case "helpScreen":
                    {
                        activeScreen = helpScreen;
                        break;
                    }
            }
            activeScreen.Show();
            double t = gameTime.TotalGameTime.TotalMilliseconds;
            if (t > 100 && activeScreen == welcomeScreen)
            {
                activeScreen.Hide();
                activeScreen = startScreen;
                activeScreen.Show();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            base.Draw(gameTime);
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;


namespace finalProject
{
    class Global
    {
        public static ContentManager Content = null;
        public static MouseEventHelper mouseHelper =new MouseEventHelper();
        public static Camera2D CurrentCamera = new Camera2D();
        
        public static void UpdateAllInvisibleEntities(GameTime gameTime)
        {
        
             CurrentCamera.Update(gameTime);
             mouseHelper.Update(gameTime);
      
        }
//        public static TileMap myMap;
        public static List<String> saveEntities=new List<string>();
  //      public static TileMap saveMap;
        public static bool Resume = false;// false means can not resume
        public static string currentScreen = "welcomeScreen";
        public static int level = 0;
        public static int mode = 0;
        public static int helpState = 1;
        public static int sound = 100;
        public static int music = 100;
        public static bool grid = false;
        
    }
        
}

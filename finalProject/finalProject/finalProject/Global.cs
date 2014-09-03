using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;


namespace WindowsGame1
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
        public static int numberOfDragon=0;
        public static int idxEntities = -1, idxMenu = -1;
        public static int flag = -1;
    }
        
}

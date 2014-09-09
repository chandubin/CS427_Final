using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace finalProject
{
    static class Tile
    {
        static public Texture2D TileSetTexture;

        static public Rectangle GetSourceRectangle(int tileIndex)
        {
            return new Rectangle(tileIndex * 45, 0, 45, 45);
        }


    }
}

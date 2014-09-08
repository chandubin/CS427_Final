using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public class Spritesheet
    {
        Rectangle rec;

        public Rectangle Rec
        {
            get { return rec; }
            set { rec = value; }
        }
        int sheet;

        public int Sheet
        {
            get { return sheet; }
            set { sheet = value; }
        }
        public Spritesheet(Rectangle _rec, int _s)
        {
            rec = _rec;
            sheet = _s;
        }

        public Spritesheet(int l, int t, int w, int h, int s)
        {
            rec = new Rectangle(l, t, w, h);
            sheet = s;
        }
    }
}

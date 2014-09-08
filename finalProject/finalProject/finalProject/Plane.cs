using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public class Plane : Enemy
    {
        public Plane(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new Animation2D(@"Enemy\Plane", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> RightAni = new List<Spritesheet>();
            RightAni.Add(new Spritesheet(176, 0, 77, 110, 0));
            RightAni.Add(new Spritesheet(0, 110, 77, 110, 0));

            _MainModel.setRightAni(RightAni);

            List<Spritesheet> DownAni = new List<Spritesheet>();
            DownAni.Add(new Spritesheet(77, 110, 88, 110, 0));
            DownAni.Add(new Spritesheet(165, 110, 88, 110, 0));
            _MainModel.setDownAni(DownAni);

            List<Spritesheet> UpAni = new List<Spritesheet>();
            UpAni.Add(new Spritesheet(0, 0, 88, 110, 0));
            UpAni.Add(new Spritesheet(88, 0, 88, 110, 0));
            _MainModel.setUpAni(UpAni);

        }
        public override int IsSelected(float X, float Y)
        {
            return -1;

        }
    }
}

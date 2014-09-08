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
            _MainModel = new Animation2D(@"Enemy\Plane", Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Rectangle> UpAni = new List<Rectangle>();
            UpAni.Add(new Rectangle(0, 0, 88, 110));
            UpAni.Add(new Rectangle(88, 0, 88, 110));
            _MainModel.setUpAni(UpAni);

            List<Rectangle> RightAni = new List<Rectangle>();
            RightAni.Add(new Rectangle(176, 0, 77, 110));
            RightAni.Add(new Rectangle(0, 110, 77, 110));
            _MainModel.setRightAni(RightAni);

            List<Rectangle> DownAni = new List<Rectangle>();
            DownAni.Add(new Rectangle(77, 110, 88, 110));
            DownAni.Add(new Rectangle(165, 110, 88, 110));
            _MainModel.setDownAni(DownAni);
            
        }
        public override int IsSelected(float X, float Y)
        {
            return -1;

        }
    }
}

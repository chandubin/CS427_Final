using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class LightUnit : Enemy
    {
        public LightUnit(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new Animation2D(@"Enemy\LightUnit", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> UpAni = new List<Spritesheet>();
            UpAni.Add(new Spritesheet(0, 0, 19, 43, 0));
            UpAni.Add(new Spritesheet(19, 0, 19, 43, 0));
            UpAni.Add(new Spritesheet(38, 0, 22, 43, 0));
            UpAni.Add(new Spritesheet(60, 0, 24, 42, 0));
            UpAni.Add(new Spritesheet(84, 0, 22, 42, 0));
            UpAni.Add(new Spritesheet(106, 0, 19, 42, 0));
            UpAni.Add(new Spritesheet(0, 43, 19, 43, 0));
            UpAni.Add(new Spritesheet(19, 43, 21, 44, 0));
            UpAni.Add(new Spritesheet(40, 43, 23, 44, 0));
            UpAni.Add(new Spritesheet(63, 42, 22, 42, 0));
            UpAni.Add(new Spritesheet(85, 42, 20, 42, 0));
            UpAni.Add(new Spritesheet(0, 86, 19, 41, 0));
            _MainModel.setUpAni(UpAni);

            List<Spritesheet> RightAni = new List<Spritesheet>();
            RightAni.Add(new Spritesheet(79, 128, 29, 41, 0));
            RightAni.Add(new Spritesheet(0, 211, 26, 43, 0));
            RightAni.Add(new Spritesheet(48, 170, 24, 44, 0));
            RightAni.Add(new Spritesheet(108, 128, 29, 43, 0));
            RightAni.Add(new Spritesheet(72, 170, 28, 42, 0));
            RightAni.Add(new Spritesheet(26, 214, 28, 41, 0));
            RightAni.Add(new Spritesheet(137, 128, 29, 41, 0));
            RightAni.Add(new Spritesheet(54, 214, 28, 42, 0));
            RightAni.Add(new Spritesheet(100, 171, 27, 43, 0));
            RightAni.Add(new Spritesheet(166, 128, 28, 43, 0));
            RightAni.Add(new Spritesheet(82, 214, 30, 42, 0));
            RightAni.Add(new Spritesheet(127, 171, 26, 41, 0));
            _MainModel.setRightAni(RightAni);

            List<Spritesheet> DownAni = new List<Spritesheet>();
            DownAni.Add(new Spritesheet(294, 86, 18, 44, 0));
            DownAni.Add(new Spritesheet(280, 130, 19, 45, 0));
            DownAni.Add(new Spritesheet(312, 89, 22, 44, 0));
            DownAni.Add(new Spritesheet(334, 89, 24, 43, 0));
            DownAni.Add(new Spritesheet(255, 175, 23, 43, 0));
            DownAni.Add(new Spritesheet(373, 46, 19, 43, 0));
            DownAni.Add(new Spritesheet(431, 0, 19, 44, 0));
            DownAni.Add(new Spritesheet(392, 46, 21, 44, 0));
            DownAni.Add(new Spritesheet(299, 133, 23, 44, 0));
            DownAni.Add(new Spritesheet(358, 89, 22, 44, 0));
            DownAni.Add(new Spritesheet(450, 0, 20, 45, 0));
            DownAni.Add(new Spritesheet(278, 175, 19, 45, 0));
            _MainModel.setDownAni(DownAni);
        }

        public override int IsSelected(float X, float Y)
        {
            {

                return -1;
            }
        }
    }
}

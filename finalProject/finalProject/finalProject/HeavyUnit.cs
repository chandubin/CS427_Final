using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class HeavyUnit : Enemy
    {
        public HeavyUnit(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new Animation2D(@"Enemy\HeavyUnit", 2, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> UpAni = new List<Spritesheet>();
            UpAni.Add(new Spritesheet(0, 0, 47, 49, 0));
            UpAni.Add(new Spritesheet(47, 0, 48, 50, 0));
            UpAni.Add(new Spritesheet(0, 49, 47, 52, 0));
            UpAni.Add(new Spritesheet(47, 50, 46, 56, 0));
            UpAni.Add(new Spritesheet(95, 0, 46, 60, 0));
            UpAni.Add(new Spritesheet(141, 0, 46, 63, 0));
            UpAni.Add(new Spritesheet(93, 60, 46, 56, 0));
            UpAni.Add(new Spritesheet(187, 0, 45, 51, 0));
            UpAni.Add(new Spritesheet(139, 63, 48, 51, 0));
            UpAni.Add(new Spritesheet(187, 51, 47, 49, 0));
            UpAni.Add(new Spritesheet(0, 116, 48, 51, 0));
            UpAni.Add(new Spritesheet(48, 116, 48, 54, 0));
            UpAni.Add(new Spritesheet(0, 167, 48, 58, 0));
            UpAni.Add(new Spritesheet(96, 116, 49, 59, 0));
            UpAni.Add(new Spritesheet(48, 170, 48, 57, 0));
            UpAni.Add(new Spritesheet(145, 114, 48, 54, 0));
            UpAni.Add(new Spritesheet(96, 175, 48, 49, 0));
            UpAni.Add(new Spritesheet(193, 100, 47, 49, 0));
            _MainModel.setUpAni(UpAni);

            List<Spritesheet> RightAni = new List<Spritesheet>();
            RightAni.Add(new Spritesheet(189, 204, 36, 58, 0));
            RightAni.Add(new Spritesheet(0, 402, 35, 59, 0));
            RightAni.Add(new Spritesheet(126, 284, 37, 60, 0));
            RightAni.Add(new Spritesheet(84, 342, 42, 61, 0));
            RightAni.Add(new Spritesheet(35, 402, 48, 60, 0));
            RightAni.Add(new Spritesheet(163, 276, 51, 59, 0));
            RightAni.Add(new Spritesheet(126, 344, 45, 58, 0));
            RightAni.Add(new Spritesheet(225, 238, 38, 58, 0));
            RightAni.Add(new Spritesheet(83, 403, 35, 59, 0));
            RightAni.Add(new Spritesheet(263, 238, 33, 59, 0));
            RightAni.Add(new Spritesheet(171, 335, 33, 60, 0));
            RightAni.Add(new Spritesheet(118, 403, 36, 61, 0));
            RightAni.Add(new Spritesheet(296, 233, 41, 61, 0));
            RightAni.Add(new Spritesheet(204, 335, 44, 60, 0));
            RightAni.Add(new Spritesheet(154, 402, 48, 58, 0));
            RightAni.Add(new Spritesheet(248, 297, 43, 57, 0));
            RightAni.Add(new Spritesheet(291, 297, 37, 57, 0));
            RightAni.Add(new Spritesheet(202, 395, 36, 58, 0));


            _MainModel.setRightAni(RightAni);

            List<Spritesheet> DownAni = new List<Spritesheet>();
            DownAni.Add(new Spritesheet(556, 160, 48, 46, 0));
            DownAni.Add(new Spritesheet(754, 0, 49, 47, 0));
            DownAni.Add(new Spritesheet(524, 211, 47, 49, 0));
            DownAni.Add(new Spritesheet(705, 55, 47, 52, 0));
            DownAni.Add(new Spritesheet(607, 156, 46, 54, 0));
            DownAni.Add(new Spritesheet(658, 105, 46, 54, 0));
            DownAni.Add(new Spritesheet(571, 210, 46, 51, 0));
            DownAni.Add(new Spritesheet(524, 260, 46, 48, 0));
            DownAni.Add(new Spritesheet(754, 47, 47, 46, 0));
            DownAni.Add(new Spritesheet(803, 0, 47, 44, 0));
            DownAni.Add(new Spritesheet(704, 107, 48, 45, 0));
            DownAni.Add(new Spritesheet(653, 159, 49, 49, 0));
            DownAni.Add(new Spritesheet(617, 210, 49, 52, 0));
            DownAni.Add(new Spritesheet(481, 346, 49, 53, 0));
            DownAni.Add(new Spritesheet(803, 44, 49, 51, 0));
            DownAni.Add(new Spritesheet(752, 93, 49, 50, 0));
            DownAni.Add(new Spritesheet(382, 465, 49, 47, 0));
            DownAni.Add(new Spritesheet(704, 152, 48, 46, 0));

            _MainModel.setDownAni(DownAni);

        }
        public override int IsSelected(float X, float Y)
        {
            return -1;

        }
    }
}

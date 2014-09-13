using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Missile : Tower
    {
        public Missile(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new TowerAni(@"Tower\Missile\Missile", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> IL1 = new List<Spritesheet>();
            IL1.Add(new Spritesheet(0, 0, 76, 66, 0));
            IL1.Add(new Spritesheet(76, 0, 76, 65, 0));
            IL1.Add(new Spritesheet(152, 0, 77, 66, 0));
            IL1.Add(new Spritesheet(0, 66, 76, 68, 0));
            IL1.Add(new Spritesheet(0, 134, 76, 68, 0));
            IL1.Add(new Spritesheet(76, 65, 76, 69, 0));
            IL1.Add(new Spritesheet(76, 134, 76, 70, 0));
            IL1.Add(new Spritesheet(152, 66, 76, 69, 0));
            IL1.Add(new Spritesheet(152, 135, 77, 68, 0));
            IL1.Add(new Spritesheet(229, 0, 76, 68, 0));
            IL1.Add(new Spritesheet(229, 68, 76, 68, 0));
            IL1.Add(new Spritesheet(305, 0, 76, 67, 0));
            IL1.Add(new Spritesheet(229, 136, 76, 68, 0));
            IL1.Add(new Spritesheet(305, 67, 76, 68, 0));
            IL1.Add(new Spritesheet(381, 0, 75, 68, 0));
            IL1.Add(new Spritesheet(305, 135, 77, 69, 0));
            IL1.Add(new Spritesheet(382, 68, 76, 70, 0));
            IL1.Add(new Spritesheet(382, 138, 76, 71, 0));
            IL1.Add(new Spritesheet(0, 202, 76, 71, 0));
            _MainModel.setIdleLevel1(IL1);

            List<Spritesheet> IL2 = new List<Spritesheet>();
            IL2.Add(new Spritesheet(0, 273, 76, 73, 0));
            IL2.Add(new Spritesheet(76, 204, 76, 73, 0));
            IL2.Add(new Spritesheet(0, 346, 76, 73, 0));
            IL2.Add(new Spritesheet(76, 277, 76, 72, 0));
            IL2.Add(new Spritesheet(152, 203, 76, 72, 0));
            IL2.Add(new Spritesheet(0, 419, 76, 72, 0));
            IL2.Add(new Spritesheet(76, 349, 76, 71, 0));
            IL2.Add(new Spritesheet(152, 275, 76, 72, 0));
            IL2.Add(new Spritesheet(228, 204, 76, 72, 0));
            IL2.Add(new Spritesheet(76, 420, 76, 73, 0));
            IL2.Add(new Spritesheet(152, 347, 75, 74, 0));
            IL2.Add(new Spritesheet(228, 276, 76, 74, 0));
            IL2.Add(new Spritesheet(304, 204, 76, 77, 0));
            IL2.Add(new Spritesheet(152, 421, 76, 79, 0));
            IL2.Add(new Spritesheet(228, 350, 77, 83, 0));
            IL2.Add(new Spritesheet(380, 209, 76, 86, 0));
            IL2.Add(new Spritesheet(305, 295, 76, 88, 0));
            IL2.Add(new Spritesheet(381, 295, 76, 89, 0));
            IL2.Add(new Spritesheet(305, 383, 76, 90, 0));
            _MainModel.setIdleLevel2(IL2);

            List<Spritesheet> IL3 = new List<Spritesheet>();
            IL3.Add(new Spritesheet(228, 433, 76, 74, 0));
            IL3.Add(new Spritesheet(381, 384, 76, 73, 0));
            IL3.Add(new Spritesheet(0, 0, 76, 76, 1));
            IL3.Add(new Spritesheet(76, 0, 76, 77, 1));
            IL3.Add(new Spritesheet(152, 0, 76, 78, 1));
            IL3.Add(new Spritesheet(0, 78, 77, 79, 1));
            IL3.Add(new Spritesheet(77, 78, 76, 80, 1));
            IL3.Add(new Spritesheet(0, 157, 76, 81, 1));
            IL3.Add(new Spritesheet(153, 78, 76, 82, 1));
            IL3.Add(new Spritesheet(76, 158, 76, 82, 1));
            IL3.Add(new Spritesheet(152, 160, 76, 82, 1));
            IL3.Add(new Spritesheet(0, 238, 76, 82, 1));
            IL3.Add(new Spritesheet(76, 240, 76, 83, 1));
            IL3.Add(new Spritesheet(0, 320, 76, 85, 1));
            IL3.Add(new Spritesheet(152, 242, 76, 87, 1));
            IL3.Add(new Spritesheet(76, 323, 76, 88, 1));
            IL3.Add(new Spritesheet(0, 405, 76, 90, 1));
            IL3.Add(new Spritesheet(152, 329, 76, 91, 1));
            IL3.Add(new Spritesheet(76, 411, 76, 92, 1));
            _MainModel.setIdleLevel3(IL3);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Goo : Tower
    {
        public Goo(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new TowerAni(@"Tower\Goo\Goo", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> IL1 = new List<Spritesheet>();
            IL1.Add(new Spritesheet(0, 0, 89, 115, 0));
            IL1.Add(new Spritesheet(89, 0, 89, 115, 0));
            IL1.Add(new Spritesheet(0, 115, 89, 114, 0));
            IL1.Add(new Spritesheet(89, 115, 89, 111, 0));
            IL1.Add(new Spritesheet(178, 0, 88, 108, 0));
            IL1.Add(new Spritesheet(266, 0, 89, 103, 0));
            IL1.Add(new Spritesheet(178, 108, 89, 99, 0));
            IL1.Add(new Spritesheet(355, 0, 89, 93, 0));
            IL1.Add(new Spritesheet(267, 103, 89, 90, 0));
            IL1.Add(new Spritesheet(356, 93, 89, 90, 0));
            IL1.Add(new Spritesheet(0, 229, 89, 91, 0));
            IL1.Add(new Spritesheet(89, 226, 89, 93, 0));
            IL1.Add(new Spritesheet(0, 320, 88, 95, 0));
            IL1.Add(new Spritesheet(178, 207, 88, 99, 0));
            IL1.Add(new Spritesheet(88, 320, 88, 102, 0));
            IL1.Add(new Spritesheet(267, 193, 89, 105, 0));
            IL1.Add(new Spritesheet(178, 306, 89, 108, 0));
            IL1.Add(new Spritesheet(356, 183, 89, 109, 0));
            IL1.Add(new Spritesheet(267, 298, 88, 110, 0));
            _MainModel.setIdleLevel1(IL1);

            List<Spritesheet> IL2 = new List<Spritesheet>();
            IL2.Add(new Spritesheet(356, 292, 89, 120, 0));
            IL2.Add(new Spritesheet(0, 0, 88, 120, 1));
            IL2.Add(new Spritesheet(88, 0, 89, 119, 1));
            IL2.Add(new Spritesheet(0, 120, 89, 117, 1));
            IL2.Add(new Spritesheet(89, 119, 89, 113, 1));
            IL2.Add(new Spritesheet(177, 0, 89, 109, 1));
            IL2.Add(new Spritesheet(266, 0, 89, 105, 1));
            IL2.Add(new Spritesheet(178, 109, 89, 103, 1));
            IL2.Add(new Spritesheet(355, 0, 88, 101, 1));
            IL2.Add(new Spritesheet(267, 105, 90, 103, 1));
            IL2.Add(new Spritesheet(357, 101, 89, 106, 1));
            IL2.Add(new Spritesheet(0, 237, 89, 110, 1));
            IL2.Add(new Spritesheet(89, 232, 89, 112, 1));
            IL2.Add(new Spritesheet(0, 347, 88, 114, 1));
            IL2.Add(new Spritesheet(178, 212, 89, 115, 1));
            IL2.Add(new Spritesheet(89, 344, 89, 115, 1));
            IL2.Add(new Spritesheet(267, 208, 89, 114, 1));
            IL2.Add(new Spritesheet(178, 327, 89, 114, 1));
            IL2.Add(new Spritesheet(356, 208, 89, 115, 1));
            _MainModel.setIdleLevel2(IL2);

            List<Spritesheet> IL3 = new List<Spritesheet>();
            IL3.Add(new Spritesheet(267, 322, 88, 120, 1));
            IL3.Add(new Spritesheet(355, 323, 89, 121, 1));
            IL3.Add(new Spritesheet(0, 0, 89, 120, 2));
            IL3.Add(new Spritesheet(89, 0, 89, 119, 2));
            IL3.Add(new Spritesheet(0, 120, 89, 117, 2));
            IL3.Add(new Spritesheet(89, 119, 89, 113, 2));
            IL3.Add(new Spritesheet(178, 0, 89, 109, 2));
            IL3.Add(new Spritesheet(267, 0, 91, 108, 2));
            IL3.Add(new Spritesheet(178, 109, 91, 106, 2));
            IL3.Add(new Spritesheet(358, 0, 90, 109, 2));
            IL3.Add(new Spritesheet(269, 109, 91, 111, 2));
            IL3.Add(new Spritesheet(360, 109, 91, 114, 2));
            IL3.Add(new Spritesheet(0, 237, 89, 114, 2));
            IL3.Add(new Spritesheet(89, 232, 89, 116, 2));
            IL3.Add(new Spritesheet(0, 351, 89, 116, 2));
            IL3.Add(new Spritesheet(178, 215, 89, 115, 2));
            IL3.Add(new Spritesheet(89, 348, 89, 116, 2));
            IL3.Add(new Spritesheet(267, 220, 89, 116, 2));
            IL3.Add(new Spritesheet(178, 330, 89, 115, 2));
            _MainModel.setIdleLevel3(IL3);

        }
    }
}

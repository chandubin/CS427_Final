using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Gatling : Tower
    {
         public Gatling(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new TowerAni(@"Tower\Gatling\Gatling", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> IL1 = new List<Spritesheet>();
            IL1.Add(new Spritesheet(0, 0, 83, 97, 0));
            IL1.Add(new Spritesheet(83, 0, 82, 96, 0));
            IL1.Add(new Spritesheet(165, 0, 83, 96, 0));
            IL1.Add(new Spritesheet(0, 97, 83, 94, 0));
            IL1.Add(new Spritesheet(83, 96, 82, 92, 0));
            IL1.Add(new Spritesheet(165, 96, 82, 89, 0));
            IL1.Add(new Spritesheet(248, 0, 83, 85, 0));
            IL1.Add(new Spritesheet(331, 0, 83, 85, 0));
            IL1.Add(new Spritesheet(248, 85, 82, 85, 0));
            IL1.Add(new Spritesheet(414, 0, 83, 85, 0));
            IL1.Add(new Spritesheet(330, 85, 83, 85, 0));
            IL1.Add(new Spritesheet(247, 170, 83, 85, 0));
            IL1.Add(new Spritesheet(413, 85, 83, 85, 0));
            IL1.Add(new Spritesheet(330, 170, 82, 85, 0));
            IL1.Add(new Spritesheet(412, 170, 83, 85, 0));
            IL1.Add(new Spritesheet(0, 191, 83, 85, 0));
            IL1.Add(new Spritesheet(83, 188, 83, 85, 0));
            IL1.Add(new Spritesheet(0, 276, 83, 85, 0));
            IL1.Add(new Spritesheet(83, 273, 83, 85, 0));
            _MainModel.setIdleLevel1(IL1);

            List<Spritesheet> IL2 = new List<Spritesheet>();
            IL2.Add(new Spritesheet(0, 361, 83, 109, 0));
            IL2.Add(new Spritesheet(166, 255, 82, 108, 0));
            IL2.Add(new Spritesheet(83, 358, 82, 108, 0));
            IL2.Add(new Spritesheet(248, 255, 82, 107, 0));
            IL2.Add(new Spritesheet(165, 363, 83, 105, 0));
            IL2.Add(new Spritesheet(330, 255, 83, 104, 0));
            IL2.Add(new Spritesheet(248, 362, 83, 102, 0));
            IL2.Add(new Spritesheet(413, 255, 82, 99, 0));
            IL2.Add(new Spritesheet(331, 359, 82, 96, 0));
            IL2.Add(new Spritesheet(413, 354, 82, 96, 0));
            IL2.Add(new Spritesheet(0, 0, 82, 97, 1));
            IL2.Add(new Spritesheet(82, 0, 82, 98, 1));
            IL2.Add(new Spritesheet(164, 0, 82, 99, 1));
            IL2.Add(new Spritesheet(0, 97, 82, 100, 1));
            IL2.Add(new Spritesheet(82, 99, 83, 100, 1));
            IL2.Add(new Spritesheet(165, 99, 82, 101, 1));
            IL2.Add(new Spritesheet(247, 0, 83, 101, 1));
            IL2.Add(new Spritesheet(330, 0, 83, 101, 1));
            IL2.Add(new Spritesheet(247, 101, 82, 101, 1));
            _MainModel.setIdleLevel2(IL2);

            List<Spritesheet> IL3 = new List<Spritesheet>();
            IL3.Add(new Spritesheet(413, 0, 83, 108, 1));
            IL3.Add(new Spritesheet(329, 101, 82, 111, 1));
            IL3.Add(new Spritesheet(411, 108, 82, 112, 1));
            IL3.Add(new Spritesheet(0, 197, 82, 113, 1));
            IL3.Add(new Spritesheet(82, 199, 83, 113, 1));
            IL3.Add(new Spritesheet(0, 310, 82, 112, 1));
            IL3.Add(new Spritesheet(82, 312, 83, 111, 1));
            IL3.Add(new Spritesheet(165, 200, 82, 109, 1));
            IL3.Add(new Spritesheet(165, 309, 83, 108, 1));
            IL3.Add(new Spritesheet(248, 212, 82, 108, 1));
            IL3.Add(new Spritesheet(248, 320, 83, 108, 1));
            IL3.Add(new Spritesheet(331, 220, 83, 108, 1));
            IL3.Add(new Spritesheet(414, 220, 83, 109, 1));
            IL3.Add(new Spritesheet(331, 328, 83, 108, 1));
            IL3.Add(new Spritesheet(414, 329, 82, 108, 1));
            IL3.Add(new Spritesheet(0, 0, 83, 106, 2));
            IL3.Add(new Spritesheet(83, 0, 83, 105, 2));
            IL3.Add(new Spritesheet(166, 0, 82, 102, 2));
            IL3.Add(new Spritesheet(0, 106, 83, 101, 2));
            _MainModel.setIdleLevel3(IL3);

            List<Spritesheet> SL1 = new List<Spritesheet>();
            SL1.Add(new Spritesheet(83, 105, 83, 113, 2));
            SL1.Add(new Spritesheet(166, 102, 82, 113, 2));
            SL1.Add(new Spritesheet(248, 0, 82, 112, 2));
            SL1.Add(new Spritesheet(330, 0, 82, 110, 2));
            SL1.Add(new Spritesheet(248, 112, 82, 107, 2));
            SL1.Add(new Spritesheet(412, 0, 86, 102, 2));
            SL1.Add(new Spritesheet(330, 110, 91, 97, 2));
            SL1.Add(new Spritesheet(0, 218, 94, 91, 2));
            SL1.Add(new Spritesheet(0, 309, 95, 85, 2));
            SL1.Add(new Spritesheet(94, 218, 95, 85, 2));
            SL1.Add(new Spritesheet(0, 394, 96, 85, 2));
            SL1.Add(new Spritesheet(95, 303, 95, 85, 2));
            SL1.Add(new Spritesheet(190, 219, 91, 85, 2));
            SL1.Add(new Spritesheet(96, 388, 87, 85, 2));
            SL1.Add(new Spritesheet(190, 304, 83, 85, 2));
            SL1.Add(new Spritesheet(281, 291, 82, 85, 2));
            SL1.Add(new Spritesheet(421, 102, 83, 85, 2));
            SL1.Add(new Spritesheet(273, 304, 83, 85, 2));
            SL1.Add(new Spritesheet(183, 389, 82, 85, 2));
            _MainModel.setShootingLevel1(SL1);

            List<Spritesheet> SL2 = new List<Spritesheet>();
            SL2.Add(new Spritesheet(363, 207, 82, 128, 2));
            SL2.Add(new Spritesheet(356, 335, 82, 128, 2));
            SL2.Add(new Spritesheet(0, 0, 83, 126, 3));
            SL2.Add(new Spritesheet(83, 0, 83, 123, 3));
            SL2.Add(new Spritesheet(166, 0, 83, 121, 3));
            SL2.Add(new Spritesheet(0, 126, 86, 117, 3));
            SL2.Add(new Spritesheet(86, 123, 90, 112, 3));
            SL2.Add(new Spritesheet(249, 0, 93, 107, 3));
            SL2.Add(new Spritesheet(176, 121, 96, 102, 3));
            SL2.Add(new Spritesheet(342, 0, 96, 96, 3));
            SL2.Add(new Spritesheet(272, 107, 96, 97, 3));
            SL2.Add(new Spritesheet(368, 96, 24, 98, 3));
            SL2.Add(new Spritesheet(0, 243, 92, 99, 3));
            SL2.Add(new Spritesheet(92, 235, 89, 100, 3));
            SL2.Add(new Spritesheet(0, 342, 84, 100, 3));
            SL2.Add(new Spritesheet(181, 223, 82, 101, 3));
            SL2.Add(new Spritesheet(84, 342, 82, 101, 3));
            SL2.Add(new Spritesheet(272, 204, 83, 101, 3));
            SL2.Add(new Spritesheet(181, 324, 83, 101, 3));
            _MainModel.setShootingLevel2(SL2);

            List<Spritesheet> SL3 = new List<Spritesheet>();
            SL3.Add(new Spritesheet(355, 204, 83, 129, 3));
            SL3.Add(new Spritesheet(264, 305, 82, 129, 3));
            SL3.Add(new Spritesheet(346, 333, 83, 129, 3));
            SL3.Add(new Spritesheet(429, 333, 83, 129, 3));
            SL3.Add(new Spritesheet(0, 0, 84, 127, 4));
            SL3.Add(new Spritesheet(84, 0, 86, 125, 4));
            SL3.Add(new Spritesheet(0, 127, 90, 122, 4));
            SL3.Add(new Spritesheet(90, 125, 94, 117, 4));
            SL3.Add(new Spritesheet(170, 0, 95, 113, 4));
            SL3.Add(new Spritesheet(265, 0, 96, 108, 4));
            SL3.Add(new Spritesheet(184, 113, 97, 108, 4));
            SL3.Add(new Spritesheet(361, 0, 95, 108, 4));
            SL3.Add(new Spritesheet(281, 108, 91, 109, 4));
            SL3.Add(new Spritesheet(372, 108, 89, 108, 4));
            SL3.Add(new Spritesheet(0, 249, 84, 108, 4));
            SL3.Add(new Spritesheet(90, 242, 84, 106, 4));
            SL3.Add(new Spritesheet(0, 357, 83, 105, 4));
            SL3.Add(new Spritesheet(184, 221, 83, 102, 4));
            SL3.Add(new Spritesheet(84, 348, 82, 101, 4));
            _MainModel.setShootingLevel3(SL3);
        }
    }
}

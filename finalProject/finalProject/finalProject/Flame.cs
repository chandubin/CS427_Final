using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Flame : Tower
    {

          public Flame(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new TowerAni(@"Tower\Flame\Flame", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> IL1 = new List<Spritesheet>();
            IL1.Add(new Spritesheet(0, 0, 72, 96, 0));
            IL1.Add(new Spritesheet(72, 0, 72, 95, 0));
            IL1.Add(new Spritesheet(144, 0, 72, 95, 0));
            IL1.Add(new Spritesheet(0, 96, 71, 92, 0));
            IL1.Add(new Spritesheet(71, 96, 72, 89, 0));
            IL1.Add(new Spritesheet(143, 95, 74, 86, 0));
            IL1.Add(new Spritesheet(216, 0, 77, 83, 0));
            IL1.Add(new Spritesheet(293, 0, 80, 80, 0));
            IL1.Add(new Spritesheet(217, 83, 81, 78, 0));
            IL1.Add(new Spritesheet(373, 0, 81, 77, 0));
            IL1.Add(new Spritesheet(217, 161, 81, 78, 0));
            IL1.Add(new Spritesheet(298, 80, 80, 80, 0));
            IL1.Add(new Spritesheet(298, 160, 78, 82, 0));
            IL1.Add(new Spritesheet(378, 77, 75, 83, 0));
            IL1.Add(new Spritesheet(376, 160, 71, 86, 0));
            IL1.Add(new Spritesheet(0, 188, 72, 88, 0));
            IL1.Add(new Spritesheet(72, 185, 71, 89, 0));
            IL1.Add(new Spritesheet(0, 276, 72, 90, 0));
            IL1.Add(new Spritesheet(143, 181, 72, 90, 0));
            _MainModel.setIdleLevel1(IL1);

            List<Spritesheet> IL2 = new List<Spritesheet>();
            IL2.Add(new Spritesheet(72, 274, 72, 96, 0));
            IL2.Add(new Spritesheet(0, 366, 72, 95, 0));
            IL2.Add(new Spritesheet(144, 271, 72, 95, 0));
            IL2.Add(new Spritesheet(72, 370, 72, 92, 0));
            IL2.Add(new Spritesheet(216, 239, 71, 89, 0));
            IL2.Add(new Spritesheet(144, 366, 74, 86, 0));
            IL2.Add(new Spritesheet(287, 242, 77, 85, 0));
            IL2.Add(new Spritesheet(218, 328, 80, 83, 0));
            IL2.Add(new Spritesheet(364, 246, 81, 83, 0));
            IL2.Add(new Spritesheet(218, 411, 81, 83, 0));
            IL2.Add(new Spritesheet(299, 329, 81, 93, 0));
            IL2.Add(new Spritesheet(380, 329, 79, 85, 0));
            IL2.Add(new Spritesheet(299, 412, 78, 87, 0));
            IL2.Add(new Spritesheet(377, 414, 75, 91, 0));
            IL2.Add(new Spritesheet(0, 0, 72, 94, 1));
            IL2.Add(new Spritesheet(72, 0, 72, 95, 1));
            IL2.Add(new Spritesheet(144, 0, 72, 97, 1));
            IL2.Add(new Spritesheet(0, 94, 72, 97, 1));
            IL2.Add(new Spritesheet(72, 95, 71, 96, 1));
            _MainModel.setIdleLevel2(IL2);

            List<Spritesheet> IL3 = new List<Spritesheet>();
            IL3.Add(new Spritesheet(143, 97, 72, 96, 1));
            IL3.Add(new Spritesheet(216, 0, 74, 95, 1));
            IL3.Add(new Spritesheet(290, 0, 76, 96, 1));
            IL3.Add(new Spritesheet(215, 97, 77, 92, 1));
            IL3.Add(new Spritesheet(366, 0, 80, 89, 1));
            IL3.Add(new Spritesheet(292, 96, 82, 86, 1));
            IL3.Add(new Spritesheet(374, 89, 83, 85, 1));
            IL3.Add(new Spritesheet(0, 191, 83, 83, 1));
            IL3.Add(new Spritesheet(0, 274, 82, 83, 1));
            IL3.Add(new Spritesheet(83, 193, 81, 84, 1));
            IL3.Add(new Spritesheet(164, 193, 81, 88, 1));
            IL3.Add(new Spritesheet(0, 357, 83, 91, 1));
            IL3.Add(new Spritesheet(245, 189, 83, 93, 1));
            IL3.Add(new Spritesheet(83, 281, 83, 95, 1));
            IL3.Add(new Spritesheet(83, 376, 80, 96, 1));
            IL3.Add(new Spritesheet(166, 281, 78, 96, 1));
            IL3.Add(new Spritesheet(328, 182, 76, 97, 1));
            IL3.Add(new Spritesheet(244, 282, 74, 98, 1));
            IL3.Add(new Spritesheet(163, 377, 71, 97, 1));
            _MainModel.setIdleLevel3(IL3);

            List<Spritesheet> SL1 = new List<Spritesheet>();
            SL1.Add(new Spritesheet(404, 174, 72, 96, 1));
            SL1.Add(new Spritesheet(318, 282, 72, 95, 1));
            SL1.Add(new Spritesheet(234, 380, 72, 96, 1));     
            SL1.Add(new Spritesheet(390, 279, 72, 92, 1));
            SL1.Add(new Spritesheet(306, 380, 72, 90, 1));
            SL1.Add(new Spritesheet(378, 377, 74, 86, 1));
            SL1.Add(new Spritesheet(0, 0, 77, 83, 2));
            SL1.Add(new Spritesheet(77, 0, 80, 80, 2));
            SL1.Add(new Spritesheet(157, 0, 81, 78, 2));
            SL1.Add(new Spritesheet(0, 83, 81, 77, 2));
            SL1.Add(new Spritesheet(0, 160, 81, 78, 2));
            SL1.Add(new Spritesheet(81, 80, 80, 80, 2));
            SL1.Add(new Spritesheet(81, 160, 78, 82, 2));
            SL1.Add(new Spritesheet(161, 78, 75, 83, 2));
            SL1.Add(new Spritesheet(159, 161, 72, 86, 2));
            SL1.Add(new Spritesheet(238, 0, 71, 88, 2));
            SL1.Add(new Spritesheet(309, 0, 72, 89, 2));
            SL1.Add(new Spritesheet(381, 0, 72, 90, 2));
            SL1.Add(new Spritesheet(231, 161, 72, 90, 2));
            _MainModel.setShootingLevel1(SL1);

            List<Spritesheet> SL2 = new List<Spritesheet>();
            SL2.Add(new Spritesheet(303, 89, 72, 96, 2));
            SL2.Add(new Spritesheet(375, 90, 72, 95, 2));
            SL2.Add(new Spritesheet(0, 238, 72, 96, 2));
            SL2.Add(new Spritesheet(72, 242, 72, 92, 2));
            SL2.Add(new Spritesheet(0, 334, 72, 89, 2));
            SL2.Add(new Spritesheet(72, 334, 74, 86, 2));
            SL2.Add(new Spritesheet(0, 423, 77, 85, 2));
            SL2.Add(new Spritesheet(146, 247, 80, 83, 2));
            SL2.Add(new Spritesheet(146, 330, 81, 83, 2));
            SL2.Add(new Spritesheet(227, 251, 81, 83, 2));
            SL2.Add(new Spritesheet(77, 420, 81, 83, 2));
            SL2.Add(new Spritesheet(308, 185, 80, 85, 2));
            SL2.Add(new Spritesheet(227, 334, 78, 87, 2));
            SL2.Add(new Spritesheet(388, 185, 75, 91, 2));
            SL2.Add(new Spritesheet(308, 270, 72, 94, 2));
            SL2.Add(new Spritesheet(380, 276, 72, 95, 2));
            SL2.Add(new Spritesheet(305, 364, 72, 97, 2));
            SL2.Add(new Spritesheet(377, 371, 72, 97, 2));
            SL2.Add(new Spritesheet(0, 0, 72, 96, 2));
            _MainModel.setShootingLevel2(SL2);

            List<Spritesheet> SL3 = new List<Spritesheet>();
            SL3.Add(new Spritesheet(72, 0, 72, 96, 3));
            SL3.Add(new Spritesheet(144, 0, 74, 95, 3));
            SL3.Add(new Spritesheet(0, 96, 76, 95, 3));
            SL3.Add(new Spritesheet(76, 96, 77, 92, 3));
            SL3.Add(new Spritesheet(153, 95, 80, 89, 3));
            SL3.Add(new Spritesheet(218, 0, 82, 86, 3));
            SL3.Add(new Spritesheet(300, 0, 83, 85, 3));
            SL3.Add(new Spritesheet(233, 86, 83, 83, 3));
            SL3.Add(new Spritesheet(383, 0, 82, 83, 3));
            SL3.Add(new Spritesheet(233, 169, 81, 84, 3));
            SL3.Add(new Spritesheet(316, 85, 81, 88, 3));
            SL3.Add(new Spritesheet(397, 83, 83, 91, 3));
            SL3.Add(new Spritesheet(0, 191, 83, 93, 3));
            SL3.Add(new Spritesheet(83, 188, 83, 95, 3));
            SL3.Add(new Spritesheet(0, 284, 80, 95, 3));
            SL3.Add(new Spritesheet(80, 284, 78, 96, 3));
            SL3.Add(new Spritesheet(0, 379, 76, 97, 3));
            SL3.Add(new Spritesheet(158, 283, 74, 98, 3));
            SL3.Add(new Spritesheet(76, 380, 72, 97, 3));


            _MainModel.setShootingLevel3(SL3);
        }
    }
}

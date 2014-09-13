using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Lightning : Tower
    {
        public Lightning(int State, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            _MainModel = new TowerAni(@"Tower\Lightning\Lightning", 1, Left, Top, Width, Height, State);
            setAni();
        }

        private void setAni()
        {
            List<Spritesheet> IL1 = new List<Spritesheet>();
            IL1.Add(new Spritesheet(0, 0, 48, 89, 0));
           _MainModel.setIdleLevel1(IL1);

            List<Spritesheet> IL2 = new List<Spritesheet>();
            IL2.Add(new Spritesheet(48, 0, 48, 91, 0));
            _MainModel.setIdleLevel2(IL2);

            List<Spritesheet> IL3 = new List<Spritesheet>();
            IL3.Add(new Spritesheet(0, 91, 53, 117, 0));
            _MainModel.setIdleLevel3(IL3);

            List<Spritesheet> SL1 = new List<Spritesheet>();
            SL1.Add(new Spritesheet(53, 91, 48, 89, 0));
            _MainModel.setShootingLevel1(SL1);

            List<Spritesheet> SL2 = new List<Spritesheet>();
            SL2.Add(new Spritesheet(0, 208, 48, 91, 0));
            _MainModel.setShootingLevel2(SL2);

            List<Spritesheet> SL3 = new List<Spritesheet>();
            SL3.Add(new Spritesheet(53, 180, 53, 117, 0));
            _MainModel.setShootingLevel3(SL3);
        }
    }
}

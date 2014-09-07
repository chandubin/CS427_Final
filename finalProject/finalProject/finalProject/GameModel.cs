using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public abstract class GameModel
    {

        public virtual void Update(GameTime gameTime)
        {
        }
        public virtual void Draw(GameTime gameTime,object Paramas)
        {
        }
        public virtual int IsSelected(float X, float Y)
        {
            return -1;
        }

        public virtual void Select(bool bSelect)
        {
            
        }
        public virtual void Circle(bool bCircle)
        {
        }
        public virtual void Over(bool bOver)
        {
           
        }
        public virtual void changeState(int s)
        {
        }
        public virtual void setRightAni(List<Rectangle> RA)
        {
        }

        public virtual void setLeftAni(List<Rectangle> RA)
        {
        }

        public virtual void setUpAni(List<Rectangle> RA)
        {
        }

        public virtual void setDownAni(List<Rectangle> RA)
        {
        }
    }
}

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
    }
}

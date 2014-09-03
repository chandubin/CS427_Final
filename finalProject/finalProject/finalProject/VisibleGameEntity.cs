using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    public abstract class VisibleGameEntity : GameEntity
    {
        public GameModel _MainModel = null;
        
        public override void Update(GameTime gameTime)
        {
            if (_MainModel != null)
            {
                _MainModel.Update(gameTime);
            }

        }
        public virtual void Draw(GameTime gameTime, object Paramas)
        {
            if (_MainModel != null)
            {
                _MainModel.Draw(gameTime, Paramas);
            }

        }

        public virtual int IsSelected(float X, float Y)
        {
            return -1;
        }

        public virtual void Select(bool bSelect)
        {
            if (_MainModel != null)
            {
                _MainModel.Select(bSelect);
            }
        }

        public virtual void Over(bool bOver)
        {
            if (_MainModel != null)
            {
                _MainModel.Over(bOver);
            }
        }

    }
}

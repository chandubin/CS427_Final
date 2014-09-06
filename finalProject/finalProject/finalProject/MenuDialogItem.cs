using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public class MenuDialogItem:VisibleGameEntity
    {
        public MenuDialogItem(string strResourceName, int nRes, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
        
            _MainModel = new Sprite2D(strResourceName, nRes, Left, Top, Width, Height);
            ((Sprite2D)_MainModel).LayerDepth = 0.99f;
        }
        public override int IsSelected(float X, float Y)
        {
           
            return _MainModel.IsSelected(X, Y);
              
         
        }
    }
}

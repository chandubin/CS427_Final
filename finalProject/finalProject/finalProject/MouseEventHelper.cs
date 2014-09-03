using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    class MouseEventHelper : InvisibleGameEntity
    {
        private MouseState CurrentState,PreviousState;
      
        private void Process()
        {
            PreviousState = CurrentState;
            CurrentState = Mouse.GetState();
        }
        public int IsInScrollingMode()
        {
            return PreviousState.ScrollWheelValue - CurrentState.ScrollWheelValue;
               
        }
        public bool IsMouseLeftButtonClicked()
        {
            return IsMouseLeftButtonUp();
        }
        public bool IsMouseLeftButtonUp()
        {
            if (PreviousState.LeftButton==ButtonState.Pressed
                    &&CurrentState.LeftButton== ButtonState.Released)
                    return true;
            return false;
        }
        
        public bool IsMouseLeftButtonDown()
        {
            if (PreviousState.LeftButton==ButtonState.Released 
                && CurrentState.LeftButton==ButtonState.Pressed)
                return true;
            return false;
        }
        public override void Update(GameTime gameTime)
        {
            Process();
            base.Update(gameTime);
        }
       public Vector2 GetMousePosition()
        {
            return new Vector2(CurrentState.X, CurrentState.Y);
        }

       internal bool IsMouseLeftButtonBeingPressed()
       {
           return CurrentState.LeftButton == ButtonState.Pressed;
       }
       internal bool IsMouseLeftButtonBeingReleased()
       {
           return CurrentState.LeftButton == ButtonState.Released;
       }

       internal Vector2 GetMousePositionDifference()
       {
           Vector2 result=Vector2.Zero;
           try
           {
               result.X=CurrentState.X-PreviousState.X;
               result.Y=CurrentState.Y-PreviousState.Y;

           }
           catch(Exception)
           {//for what?
           }
           return result;
       }
    }
}

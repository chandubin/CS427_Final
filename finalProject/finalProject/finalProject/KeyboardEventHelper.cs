using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace finalProject
{
    class KeyboardEventHelper : InvisibleGameEntity
    {
        private KeyboardState CurrentState, PreviousState;

        public override void Update(GameTime gameTime)
        {
            Process();
            base.Update(gameTime);
        }

        private void Process()
        {
            PreviousState = CurrentState;
            CurrentState = Keyboard.GetState();
        }

        public bool IsKeyReleased(Keys key)
        {
            try
            {
                if (PreviousState.IsKeyDown(key) && CurrentState.IsKeyUp(key))
                    return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public bool IsKeyPressed(Keys key)
        {
            try
            {
                if (PreviousState.IsKeyUp(key) && CurrentState.IsKeyDown(key))
                    return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        internal bool IsKeyBeingPressed(Keys keys)
        {
            return CurrentState.IsKeyDown(keys);
        }
    }
}

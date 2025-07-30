using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class PlayerControls: MovementControl
    {
        public override void Input()
        {
           if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                Movement.Y = -1;
            }
           else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Movement.Y = 1;
            }
           else
            {
                Movement.Y = 0;
            }
           if (Keyboard.GetState ().IsKeyDown(Keys.F))
            {
                Movement.X = 1;
            }
           else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Movement.X = -1;
            }
           else
            {
                Movement.X = 0;
            }
           if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
            {
                Speed = 6;
            }
           else
            {
                Speed = 4;
            }
        }
    }
}

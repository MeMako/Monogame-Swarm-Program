using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    abstract class MovementControl
    {
        public Vector2 Movement;
        public float Speed;
        public abstract void Input();
        
    }
    
}

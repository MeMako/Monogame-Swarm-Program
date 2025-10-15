using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class BotControls
    {
        public transform2d transform;
        public BotControls()
        {
            transform = new transform2d(new Vector2(0, 0), new Vector2(0, 0), new Vector2(1, 1), 100f, 0f);
        }
     public float getheading()
        {
            return MathF.Atan2(transform.velocity.X, transform.velocity.Y);
        }   
     public void update()
        {

            transform.update();
        }

    }
}

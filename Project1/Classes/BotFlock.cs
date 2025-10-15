using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class BotFlock
    {
        public BotControls[] flock;
        Random rand = new Random();
        public BotFlock(int flocksize)
        {
            flock = new BotControls[flocksize];
            populateflock();
        }
        private void populateflock()
        {
            for (int i = 0; i < flock.Length; i++)
            {
                flock[i] = new BotControls();
                flock[i].transform.Force(new Microsoft.Xna.Framework.Vector2(rand.Next(), rand.Next()), 0.45f);
            }
        }
        public void updateflock()
        {
            foreach(BotControls bot in flock)
            {
                
                bot.update();
               if (MathHelper.magnitude(new Microsoft.Xna.Framework.Vector2(1280 / 2, 1280 / 2), bot.transform.position) > 5)
                {
                    //bot.transform.Force(bot.transform.velocity, -0.46f);
                    bot.transform.Force(new Microsoft.Xna.Framework.Vector2(rand.Next(), rand.Next()), 0.46f);
                }
               else 
                {
                    bot.transform.Force(new Microsoft.Xna.Framework.Vector2(1280 / 2, 1280 / 2) - bot.transform.position, -0.45f);
                }

                /* if (bot.transform.position.X > 1280 || bot.transform.position.X < 0 || bot.transform.position.Y > 1280 || bot.transform.position.Y < 0)
                 {
                     bot.transform.Force(new Microsoft.Xna.Framework.Vector2(640, 640) - bot.transform.position, 0.45f); 

                 } */
            }
        }
    }
}


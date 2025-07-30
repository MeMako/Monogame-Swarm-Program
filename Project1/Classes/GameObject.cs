using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class GameObject
    {
        public MovementControl MovementControl;
        public transform2d transform;
        public Texture2D sprite;
        private string assetName;
        public void load(ContentManager content)
        {
            sprite = content.Load<Texture2D>(assetName);
        }
        public GameObject(transform2d transform, MovementControl MovementControl, string assetName)
        {
            this.transform = transform;
            this.MovementControl = MovementControl;
            this.assetName = assetName;
        }
        public void update()
        {
            MovementControl.Input();
            if (MovementControl.Movement != Vector2.Zero )
            {
                transform.Force(MovementControl.Movement, MovementControl.Speed);
            }
            transform.update();
        }
    }
}

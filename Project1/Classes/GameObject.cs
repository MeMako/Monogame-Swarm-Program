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
        public transform2d transform;
        public Texture2D sprite;
        private string assetName;
        public void load(ContentManager content)
        {
            sprite = content.Load<Texture2D>(assetName);
        }
        public GameObject(transform2d transform, string assetName)
        {
            this.transform = transform;
            this.assetName = assetName;
        }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class transform2d
    {
        public Vector2 position { get; protected set; }
        public Vector2 velocity { get; protected set; }
        public Vector2 scale { get; protected set; }
        public float mass { get; protected set; }
        public float rotation { get; protected set; }
        public float drag { get; protected set; }
        public transform2d(Vector2 position, Vector2 velocity, Vector2 scale, float mass, float rotation)
        {
            this.position = position;
            this.velocity = velocity;
            this.scale = scale;
            this.mass = mass;
            this.rotation = rotation;
            this.drag = 0.1f;
        }
        public void update()
        {
            Move(velocity);
           velocity -= velocity * drag;
            if (velocity.LengthSquared() <= 0.1f)
            {
                velocity = Vector2.Zero;
            }
        }

        public void Move(Vector2 delta)
        {
            position += delta;
        }
        public void Force(Vector2 direction, float amount)
        {
            direction.Normalize();
            velocity += (direction * amount)/mass;
        }
        public void Scale(Vector2 delta)
        {
            scale += delta;
        }

        public void Rotatation(float delta)
        {
            rotation += delta;
        }
    }
}

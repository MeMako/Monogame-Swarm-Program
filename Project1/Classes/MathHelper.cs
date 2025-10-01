using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    internal class MathHelper
    {
        public static float map(float value, float inMin, float inMax, float outMin, float outMax)
        {
            return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }
        public static float constrain(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        public static float magnitude(Microsoft.Xna.Framework.Vector2 Vector1, Microsoft.Xna.Framework.Vector2 Vector2)
        {
            return absolute((float)Math.Sqrt(Math.Pow(Vector2.X - Vector1.X, 2) + Math.Pow(Vector2.Y - Vector1.Y, 2)));
        }
        public static float distance(Microsoft.Xna.Framework.Vector2 Vector1, Microsoft.Xna.Framework.Vector2 Vector2)
        {
            return (float)Math.Sqrt(Math.Pow(Vector2.X - Vector1.X, 2) + Math.Pow(Vector2.Y - Vector1.Y, 2));
        }
        public static float absolute(float value)
        {
            return (value < 0) ? -value : value;
        }
    }
}

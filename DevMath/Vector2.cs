using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
           get => (float)Math.Sqrt((x*x) + (y*y));
        }

        public Vector2 Normalized
        {
            get => this / Magnitude;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.x * rhs.x) + (lhs.y * rhs.y);
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a + ((b - a) * t);
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            return (float)(Math.Atan2(lhs.x, lhs.y) - Math.Atan2(rhs.x, rhs.y));
        }

        public static Vector2 DirectionFromAngle(float angleInDegrees)
        {
            float angleInRadians = DevMath.DegToRad(angleInDegrees);

            return new Vector2((float)Math.Cos(angleInRadians), (float)Math.Sin(angleInRadians));
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return v * -1;
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }

        public static Vector2 operator *(float scalar, Vector2 rhs)
        {
            return new Vector2(rhs.x * scalar, rhs.y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x / scalar, lhs.y / scalar);
        }
    }
}

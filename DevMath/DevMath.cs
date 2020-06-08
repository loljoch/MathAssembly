using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevMath
{
    public class DevMath
    {
        public const float RAD_TO_DEG = 57.2957795f;
        public const float DEG_TO_RAD = 0.0174532925f;


        public static float Lerp(float a, float b, float t)
        {
            return a + ((b - a)*t);
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            return (float)(startVelocity + ((acceleration * time) * 0.5f) * time);
        }

        public static float Clamp(float value, float min, float max)
        {
            if(value < min) return min;
            if(value > max) return max;
            return value;
        }

        public static float RadToDeg(float angle)
        {
            return angle * RAD_TO_DEG;
        }

        public static float DegToRad(float angle)
        {
            return angle * DEG_TO_RAD;
        }
    }
}

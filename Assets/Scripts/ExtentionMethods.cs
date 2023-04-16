using UnityEngine;
using System;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UI.Image;


namespace MODI.MissionPlan
{
    public static class ExtentionMethods
    {
        public static string AngleToDirection(float angle)
        {

            if (angle > 360)
            {
                float _round = Mathf.Floor(angle / 360);
                angle -= (360 * _round);
            }

            if (angle >= 0 && angle <= 30 || angle > 330 && angle <= 360)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "N");
            }

            if (angle > 30 && angle <= 60)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "NE");
            }

            if (angle > 60 && angle <= 120)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "E");
            }

            if (angle > 120 && angle <= 150)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "SE");
            }

            if (angle > 150 && angle <= 210)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "S");
            }
            if (angle > 210 && angle <= 240)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "SW");
            }

            if (angle > 240 && angle <= 300)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "W");
            }

            if (angle > 300 && angle <= 330)
            {
                return string.Format("{0}° {1}", (float)Math.Round(angle, 2), "NW");
            }

            return "Angle not Found";
        }


        public static float FormatDistance(Vector3 origin, Vector3 target)
        {
            return (float)Math.Round(Vector3.Distance(origin, target), 2);
        }

        public static float FormatAngleDistance(Vector3 origin, Vector3 target)
        {
            return Quaternion.Angle(Quaternion.Euler(origin), Quaternion.Euler(target));
        }

        public static string Altitude(float target)
        {
            char upArrow = '↑';
            return "" + upArrow + Math.Round(target, 2);
        }

    }

}
using System;
using UnityEngine;

namespace SunTrail.Core
{
    public static class SunTrailMath
    {
        /// <summary>
        /// Decodes MapTiler Terrain-RGB v2 pixel to elevation in meters.
        /// Height (m) = -10000 + ((R * 256^2 + G * 256 + B) * 0.1)
        /// </summary>
        public static float DecodeTerrainRGB(Color color)
        {
            float r = color.r * 255f;
            float g = color.g * 255f;
            float b = color.b * 255f;
            
            return -10000f + ((r * 65536f + g * 256f + b) * 0.1f);
        }

        /// <summary>
        /// Calculates the slope angle in degrees from a surface normal and the world up vector.
        /// </summary>
        public static float CalculateSlopeAngle(Vector3 normal, Vector3 up)
        {
            float dot = Vector3.Dot(normal.normalized, up.normalized);
            float angleRad = Mathf.Acos(Mathf.Clamp(dot, -1f, 1f));
            return angleRad * Mathf.Rad2Deg;
        }

        /// <summary>
        /// Returns the alert color based on the slope angle (Alpine Safety).
        /// > 30° Yellow, > 35° Orange, > 40° Red.
        /// </summary>
        public static Color GetSlopeAlertColor(float angleDeg)
        {
            if (angleDeg >= 40f) return new Color(1f, 0f, 0f, 0.55f); // Red
            if (angleDeg >= 35f) return new Color(1f, 0.5f, 0f, 0.55f); // Orange
            if (angleDeg >= 30f) return new Color(1f, 1f, 0f, 0.55f); // Yellow
            return Color.clear;
        }
    }
}

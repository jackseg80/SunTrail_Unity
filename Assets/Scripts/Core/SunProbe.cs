using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunTrail.Core
{
    public class SunProbe : MonoBehaviour
    {
        [Header("Probe Settings")]
        public int steps = 96; // 15 min steps on 24h
        public float stepDistance = 300f; // 300m
        public float maxDistance = 40000f; // 40km
        
        [Header("State")]
        public bool isSunlightVisible = true;
        public float currentSunExposure = 0f;

        /// <summary>
        /// Perform a ray-march to check if the sun is visible from a given point.
        /// </summary>
        /// <param name="origin">World position of the point to probe.</param>
        /// <param name="sunDirection">Vector pointing to the sun.</param>
        /// <returns>True if the sun is not obscured by terrain.</returns>
        public bool CheckSunVisibility(Vector3 origin, Vector3 sunDirection)
        {
            // Implementation depends on how we sample terrain height.
            // Option A: Physics.Raycast (Simple but requires colliders)
            // Option B: Sampling Cesium terrain height (More complex)
            
            for (int i = 1; i <= steps; i++)
            {
                float distance = i * stepDistance;
                if (distance > maxDistance) break;

                Vector3 probePoint = origin + sunDirection * distance;
                
                // TODO: Sample Terrain Height at probePoint
                // if (TerrainHeightAt(probePoint) > probePoint.y) return false;
            }

            return true;
        }
    }
}

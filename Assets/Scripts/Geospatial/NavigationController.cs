using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SunTrail.Core;

namespace SunTrail.Geospatial
{
    public class NavigationController : MonoBehaviour
    {
        [Header("FlyTo Settings")]
        public float flyDuration = 3f;
        
        private Coroutine _currentFlyTo;

        /// <summary>
        /// Fly smoothly to a target location using a parabolic trajectory and cubic easing.
        /// </summary>
        public void FlyTo(Vector3 targetPosition, float targetAltitude)
        {
            if (_currentFlyTo != null) StopCoroutine(_currentFlyTo);
            _currentFlyTo = StartCoroutine(FlyToCoroutine(targetPosition, targetAltitude));
        }

        private IEnumerator FlyToCoroutine(Vector3 targetPosition, float targetAltitude)
        {
            Vector3 startPosition = transform.position;
            float elapsed = 0f;

            while (elapsed < flyDuration)
            {
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / flyDuration);
                
                // Cubic ease in/out
                float easedT = t < 0.5f ? 4f * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
                
                // LERP position
                Vector3 currentPos = Vector3.Lerp(startPosition, targetPosition, easedT);
                
                // Parabolic altitude arc
                float arcHeight = Mathf.Sin(Mathf.PI * easedT) * (Vector3.Distance(startPosition, targetPosition) * 0.2f);
                currentPos.y += arcHeight;

                transform.position = currentPos;
                yield return null;
            }
            
            transform.position = targetPosition;
            _currentFlyTo = null;
        }

        /// <summary>
        /// Smoothly interpolates GPS coordinates at 60 FPS.
        /// </summary>
        public Vector3 SmoothGpsPosition(Vector3 currentPos, Vector3 targetGpsPos, float smoothingFactor = 0.1f)
        {
            return Vector3.Lerp(currentPos, targetGpsPos, smoothingFactor);
        }
    }
}

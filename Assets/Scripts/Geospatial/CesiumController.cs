using UnityEngine;
using CesiumForUnity;
using SunTrail.Core;

namespace SunTrail.Geospatial
{
    [RequireComponent(typeof(CesiumGeoreference))]
    public class CesiumController : MonoBehaviour
    {
        public StateSo globalState;
        private CesiumGeoreference _georeference;

        private void Start()
        {
            _georeference = GetComponent<CesiumGeoreference>();
            if (globalState == null) return;

            InitializeCesium();
        }

        public void InitializeCesium()
        {
            // On se place à 500m d'altitude pour voir le sol de TRÈS PRÈS
            _georeference.SetOriginLongitudeLatitudeHeight(
                globalState.targetLon, 
                globalState.targetLat, 
                500.0 
            );
            
            Debug.Log($"[SunTrail] TEST : Placé à 500m au-dessus de {globalState.targetLat}");
        }
    }
}

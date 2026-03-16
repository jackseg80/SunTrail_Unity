using UnityEngine;

namespace SunTrail.Core
{
    [CreateAssetMenu(fileName = "SecretSettings", menuName = "SunTrail/Secret Settings")]
    public class SecretSettings : ScriptableObject
    {
        [Header("Cesium Ion")]
        public string cesiumIonToken;

        [Header("MapTiler")]
        public string mapTilerKey;

        [Header("Overpass / OpenStreetMap")]
        public string userAgent = "SunTrail-Unity-App";

        // Singleton-like access for runtime
        private static SecretSettings _instance;
        public static SecretSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Resources.Load<SecretSettings>("SecretSettings");
                }
                return _instance;
            }
        }
    }
}

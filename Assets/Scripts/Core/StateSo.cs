using UnityEngine;

namespace SunTrail.Core
{
    [CreateAssetMenu(fileName = "NewGlobalState", menuName = "SunTrail/Global State")]
    public class StateSo : ScriptableObject
    {
        [Header("Configuration & Preferences")]
        public bool energySaver = false;
        public string mapSource = "swisstopo";
        public PresetType performancePreset = PresetType.Balanced;
        
        [Header("Active Performance Settings")]
        public PerformanceSettings currentSettings;

        [Header("Toggles")]
        public bool showTrails = false;
        public bool showSlopes = false;
        public bool showDebug = true;

        [Header("Geospatial Positioning (64-bit)")]
        [Tooltip("Using double for Cesium precision")]
        public double targetLat = 46.6863;
        public double targetLon = 7.6617;
        public double initialLat = 46.6863;
        public double initialLon = 7.6617;
        public int zoom = 12;
        public float reliefExaggeration = 1.4f;

        [Header("Navigation")]
        public bool isFollowingTrail = false;
        public bool isFollowingUser = false;
        public bool isOffline = false;

        // Note: Dynamic state like "current FPS", "last GPS fix", 
        // or "smoothUserPos" should ideally not live in the ScriptableObject 
        // to avoid saving runtime data into the Unity Editor asset.
        // We will handle runtime dynamic state via Events or a runtime Monobehaviour manager.
    }
}

using System;
using UnityEngine;

namespace SunTrail.Core
{
    public enum PresetType
    {
        Eco,
        Balanced,
        Performance,
        Ultra,
        Custom
    }

    [Serializable]
    public struct PerformanceSettings
    {
        public int resolution;
        public int range;
        public bool shadows;
        public int shadowRes;
        public float pixelRatioLimit;
        public bool showVegetation;
        public bool showSignposts;
        public bool showBuildings;
        public bool buildingsShadows;
        public int maxAllowedZoom;
        public int vegetationDensity;
        public int buildingBatchSize;
        public int maxBuildsPerCycle;
        public float loadDelayFactor;
        public bool showWeather;
        public int weatherDensity;
        public float weatherSpeed;
        public float fogFar;
    }

    [Serializable]
    public struct Peak
    {
        public int id;
        public string name;
        public double lat;
        public double lon;
        public float ele;
    }
}

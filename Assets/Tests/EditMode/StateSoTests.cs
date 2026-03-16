using NUnit.Framework;
using UnityEngine;
using SunTrail.Core;

namespace SunTrail.Tests
{
    public class StateSoTests
    {
        [Test]
        public void StateSo_DefaultValues_AreCorrectlyInitialized()
        {
            // Act
            StateSo state = ScriptableObject.CreateInstance<StateSo>();

            // Assert
            Assert.IsNotNull(state);
            Assert.AreEqual(46.6863, state.targetLat, "Target Latitude should use high-precision 64-bit default (46.6863)");
            Assert.AreEqual(7.6617, state.targetLon, "Target Longitude should use high-precision 64-bit default (7.6617)");
            Assert.AreEqual(1.4f, state.reliefExaggeration, "Relief Exaggeration should default to 1.4");
            Assert.AreEqual("swisstopo", state.mapSource, "Default map source should be swisstopo");
            Assert.AreEqual(PresetType.Balanced, state.performancePreset, "Default preset should be Balanced");
        }
    }
}

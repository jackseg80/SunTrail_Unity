# Changelog

All notable changes to this project will be documented in this file.

## [Unreleased]
### Added
- **Core**: Created `DataTypes.cs` containing `PresetType`, `PerformanceSettings`, and `Peak` structs.
- **Core**: Implemented `StateSo.cs` (ScriptableObject) for centralized global state management, replacing the old `state.ts` JSON-like structure.
- **Tests**: Added `StateSoTests.cs` to verify default initializations, ensuring Cesium-ready 64-bit precision (double) for geospatial coordinates.
- **Architecture**: Established Assembly Definitions (`SunTrail.Core.asmdef`, `SunTrail.Tests.EditMode.asmdef`) for proper modularity and testing.
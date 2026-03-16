# 🛰️ SunTrail Unity - Mandats (v1.0)

Ce fichier définit les mandats prioritaires pour Gemini CLI dans le projet Unity.

## 🔴 Règle d'Or : Partner Engineer Workflow
Toute intervention DOIT suivre scrupuleusement la méthodologie définie dans [CLAUDE.md](./CLAUDE.md) :
1. **Analyse & Intelligence** (Impacts, Nettoyage, Performance)
2. **Planification** (Étape par étape structurée)
3. **Implémentation Chirurgicale** (Une à la fois, Typage strict C#)
4. **Tests & Qualité** (Unity Test Framework - Edit/PlayMode)
5. **Documentation** (Changelog/TODO)
6. **Livraison** (Commit atomique & Validation)

## 🏗️ Architecture & Intégrité
- **State Management** : Utilisation de `ScriptableObjects` pour l'état global (`StateSo.cs`).
- **Precision Geospatial** : Utilisation impérative de `double` (DVector3) via Cesium pour les coordonnées ECEF/WGS84.
- **Performance Mobile** : 
    - Mode "Deep Sleep" (0 FPS en background).
    - Bridage FPS (30/60) via `Application.targetFrameRate`.
    - Optimisation VRAM (Compression KTX2/Basis).

## 🧭 Référence Source
- Ancien code Three.js disponible dans `/ReferenceSource/src/modules/`.
- Priorité de portage : `sun.ts`, `terrain.ts` et `geo.ts`.

# 🛰️ SunTrail Unity - Master TODO & Roadmap (v1.0)

Ce document suit l'évolution du projet SunTrail de Three.js vers Unity + Cesium.

## 🏔️ PHASE 1 : INFRASTRUCTURE & MOTEUR GÉOSPATIAL (En Cours)
*Objectif : Poser les fondations 64-bit et la navigation cinématique.*
- [x] Initialiser la structure de dossiers Unity.
- [x] Rédiger le plan de migration et valider les compromis architecturaux (Verdict Sévère).
- [x] Migrer la gestion de l'État Global (`StateSo.cs`).
- [ ] Configurer la Scène Cesium avec `CesiumGeoreference` (Précision 64-bit).
- [ ] Connecter les sources de tuiles (MapTiler/Swisstopo) hors Cesium Ion.
- [ ] Implémenter le contrôleur de caméra **Cinemachine** avec "Auto-Tilt" parabolique.
- [ ] Créer le système de **Lissage GPS (60 FPS)** via interpolation `SmoothDamp`.

## ☀️ PHASE 2 : INTELLIGENCE ALPINISTE (Analyse & Shaders)
*Objectif : Rendre le terrain "intelligent" (pentes, soleil, sommets).*
- [ ] **Shader d'Inclinomètre Pro** : Shader Graph URP calculant `dot(Normal, Up)` pour les zones d'avalanche (Jaune/Orange/Rouge).
- [ ] **Sun Probe (Burst System)** : Ray-marching asynchrone pour l'analyse d'ensoleillement 24h (96 pas).
- [ ] **Moteur de Sommets (Peaks)** : Portage de `peaks.ts` avec cache local JSON (Overpass API).
- [ ] **Éphémérides Photo** : Calcul Golden/Blue Hour et phases de lune (C# SunCalc).

## 🥾 PHASE 3 : NAVIGATION & TRACES GPX
*Objectif : Exploitation des données de randonnée.*
- [ ] **GPX Parser Natif** : Lecture XML performante des traces.
- [ ] **Analyse de Pente GPX** : Coloration du profil altimétrique selon la difficulté terrain.
- [ ] **Générateur SOS SMS** : Message optimisé (Lat/Lon, Alt, % Bat) pour zones sans data.
- [ ] **Boussole Stabilisée** : Gestion de la zone morte (1.5°) et amortissement magnétique.

## 🌲 PHASE 4 : IMMERSION & ENVIRONNEMENT
*Objectif : Rendre le monde vivant.*
- [ ] **Végétation Bio-Fidèle** : Adaptation des essences selon l'altitude (Mélèzes > 1800m, etc.).
- [ ] **Bâtiments 3D OSM** : Extrusion procédurale et gestion des ombres portées.
- [ ] **Météo Dynamique** : Système de particules URP (Pluie, Neige, Nuages) synchronisé avec Open-Meteo.
- [ ] **Hydrologie OSM** : Shaders de lacs et rivières avec réflexion.

## 🔋 PHASE 5 : OPTIMISATION & MOBILE
*Objectif : Performance et autonomie.*
- [ ] **Mode "Deep Sleep"** : Arrêt du rendu (0 FPS) via `OnApplicationFocus`.
- [ ] **Native Location Service** : Plugin Kotlin/Swift pour le suivi GPS en arrière-plan (écran éteint).
- [ ] **Scraper Offline** : Système de mise en cache locale pour les zones blanches.
- [ ] **UI Toolkit HUD** : Interface responsive USS/UXML (Boussole, Altimètre, Recherche).

## 🏁 TERMINÉ
- [x] Analyse exhaustive de l'ancien projet (`ReferenceSource`).
- [x] Alignement des mandats IA (`GEMINI.md`, `CLAUDE.md`).
- [x] Infrastructure de base C# (`StateSo`, `DataTypes`).

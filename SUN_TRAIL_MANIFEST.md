# 🛰️ SunTrail Unity - Manifeste Technique (v1.0)

Ce document définit les spécifications techniques et les algorithmes portés de SunTrail Three.js vers Unity + Cesium.

---

## 1. Principes Fondamentaux de Migration

### A. Précision 64-bit (Saut Quantique)
Contrairement à la version Web limitée au 32-bit (provoquant des tremblements à grande distance), SunTrail Unity utilise le système de coordonnées ECEF (Earth-Centered, Earth-Fixed) en `double` via Cesium. 
- **Règle** : Toutes les coordonnées GPS sont manipulées en `double` avant d'être converties en coordonnées Unity locales relatives à la caméra.

### B. Architecture Réactive
L'État Global (`StateSo.cs`) est la source de vérité. Les composants s'abonnent aux changements pour éviter les calculs inutiles chaque frame.

---

## 2. Algorithmes Critiques

### A. Inclinomètre (Calcul de Pente)
Le calcul se fait directement dans le Shader Graph pour une performance GPU maximale.
- **Formule** : `slope = acos(dot(WorldNormal, WorldUp))`
- **Up Vector** : Doit être extrait de la matrice de transformation de Cesium car le "Haut" change selon la position sur la sphère terrestre.
- **Seuils Alpinistes** :
  - **Jaune** : > 30° (Attention)
  - **Orange** : > 35° (Danger)
  - **Rouge** : > 40° (Danger Critique)

### B. Sun Probe (Analyse d'Horizon)
Portage optimisé via **C# Job System + Burst**.
- **Échantillonnage** : 96 pas (toutes les 15 min sur 24h).
- **Technique** : `Physics.Raycast` ou `Physics.CheckSphere` asynchrone sur le maillage Cesium.
- **Distance Max** : 40km.

### C. FlyTo Cinématique
Utilisation de **Cinemachine** avec des courbes de bruit et d'amortissement pour simuler un vol de drone.
- **Trajectoire** : Parabolique (Auto-Tilt).
- **Sécurité** : `Anti-Collision Raycast` pour maintenir la caméra au-dessus du sol + 30m.

---

## 3. Presets de Performance (Unity Standard)

| Preset | Résolution Terrain | Range (LOD) | Ombres | Végétation |
| :--- | :--- | :--- | :--- | :--- |
| **Eco** | Low | 3km | Off | Off |
| **Balanced** | Medium | 6km | Hard | Low |
| **Performance** | High | 10km | Soft | Med |
| **Ultra** | Ultra | 20km+ | HQ | High |

---

## 4. Spécificités Mobile (Suisse/Alpinisme)
- **SOS SMS** : Formatage `Lat: {lat}, Lon: {lon}, Alt: {alt}m, Bat: {bat}%`.
- **Offline Cache** : Stockage persistant des tuiles dans `Application.persistentDataPath`.
- **Boussole** : Filtrage par zone morte de 1.5° pour éviter le bruit du magnétomètre.

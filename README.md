# 🛰️ SunTrail Unity

**Le moteur topographique de précision pour l'alpinisme et la sécurité en montagne.**

SunTrail Unity est l'évolution "Pro" du moteur SunTrail (originellement développé en Three.js). Il combine la puissance de **Unity 6** avec la précision géospatiale mondiale de **Cesium**, offrant un outil d'analyse 3D inégalé pour les randonneurs, skieurs de randonnée et alpinistes.

---

## 🏔️ Pourquoi SunTrail Unity ?

*   **Précision Mondiale 64-bit** : Grâce à Cesium, finis les tremblements de caméra. La précision est métrique, que vous soyez au sommet de l'Everest ou dans votre jardin.
*   **Analyse de Sécurité Alpine** : Un inclinomètre GPU calculant les pentes au pixel près pour identifier les zones à risques d'avalanches (>30°, >35°, >40°).
*   **Intelligence Solaire (Burst Mode)** : Analyse d'ensoleillement ultra-rapide via le *C# Job System* pour calculer l'ombre portée du relief sur 24h.
*   **Performance Mobile Native** : Optimisé pour durer toute la journée en montagne grâce au mode "Deep Sleep" et au bridage intelligent du rafraîchissement (FPS).

---

## 🛠️ Stack Technique

- **Moteur** : Unity 6 (URP - Universal Render Pipeline).
- **Géospatial** : Cesium for Unity (WGS84 / ECEF).
- **Langage** : C# Natif avec optimisation **Burst & Job System**.
- **UI** : UI Toolkit (UXML/USS) pour une interface moderne et légère.
- **Données** : OpenStreetMap (Bâtiments/POI), MapTiler (Terrain-RGB), Swisstopo.

---

## 🚀 Installation & Configuration

1. **Cloner le projet** : `git clone https://github.com/jackseg80/SunTrail_Unity.git`.
2. **Ouvrir avec Unity Hub** : Utiliser Unity 6.0 ou supérieur.
3. **Cesium Ion** : Configurez votre `Ion Token` dans le panneau Cesium pour activer le streaming des tuiles mondiales.
4. **MapTiler** : Pour les données topographiques spécifiques, renseignez votre clé API dans le `StateSo` (ScriptableObject).

---

## 🏗️ Architecture "Partner Engineer"

Ce projet suit une méthodologie rigoureuse de développement assisté par IA (Gemini/Claude) :
- **Analyse & Intelligence** : Chaque feature est analysée pour son impact batterie/RAM.
- **Planification** : Utilisation systématique de `TODO.md` et `SUN_TRAIL_MANIFEST.md`.
- **Tests** : 100% vert requis sur les tests EditMode/PlayMode.

---

## 📜 Licence & Crédits

- **Développeur** : Jackseg
- **Données** : © OpenStreetMap contributors, Cesium Ion, MapTiler, Swisstopo.

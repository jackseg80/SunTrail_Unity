# 🛰️ SunTrail Unity - Guide Développeur (v1.0)

## Environnement & Langue
- **Langue :** Toutes les interactions et réponses doivent être en **Français**.
- **Système :** Travail sur **Windows** (PowerShell).
- **Unity Version :** Unity 6+ (URP).

## Méthodologie de Développement "Partner Engineer"
Toute intervention majeure (feature ou refactor) DOIT suivre ce cycle itératif :
1.  **Analyse & Intelligence** : Analyse approfondie du besoin avec l'intelligence maximale du modèle pour identifier les impacts collatéraux et les opportunités de nettoyage.
2.  **Planification** : Création d'un plan d'action structuré (étape par étape) avant toute modification de code via `enter_plan_mode`.
3.  **Implémentation Chirurgicale** : Une seule modification à la fois. Code propre, typé (C#) et idiomatic Unity.
4.  **Tests & Qualité** : Utilisation systématique de `Unity Test Framework`. **100% de succès exigé.**
5.  **Documentation** : Mise à jour immédiate de `SUN_TRAIL_MANIFEST.md`, `CHANGELOG.md` et `TODO.md`.
6.  **Livraison** : Validation via la console Unity (pas d'erreurs/warnings critiques) suivi d'un commit normé.

## Architecture Technique Unity
- **Global State :** `Assets/Scripts/Core/StateSo.cs` (ScriptableObject). Centralise : LOD, GPS, Presets Performance.
- **Suivi GPS Ultra-Lisse :** Interpolation (LERP) à 60 FPS dans `Update()` ou `LateUpdate()`.
- **Moteur de Sommets :** Portage de `peaks.ts`. Cache local via fichiers JSON persistants (`Application.persistentDataPath`).
- **Vol Cinématique (`flyTo`) :** Trajectoire parabolique avec interpolation `easeInOutCubic`.
- **Optimisation Batterie :** Mode "Deep Sleep" via `OnApplicationFocus`.
- **UI Toolkit :** Utilisation systématique de l'USS (Unity Style Sheets) pour une UI responsive.

## Commandes de Développement
- Utiliser `run_shell_command` pour les tâches de fichiers.
- Pas de commande de "build" directe ici, mais validation par compilation C#.

## Stratégie de Versioning
- **Messages de Commit** : Prefixes `feat:`, `fix:`, `perf:`, `refactor:`, `docs:`, `test:`.
- **Atomicité** : Un commit = Une étape du plan validée.

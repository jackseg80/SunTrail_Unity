# TODO

## En Cours
- [ ] Remplacer l'algorithme "Sun Probe" par un système natif C# Job System + Burst Compiler pour des performances optimales sur mobile.

## À Faire (Prochaines Étapes)
- [ ] Créer le Shader Graph "Inclinomètre" pour les tuiles Cesium (HLSL custom node avec `dot(Normal, Up)`).
- [ ] Mettre en place les Event Channels (ex: `OnLocationChanged`) pour remplacer l'interrogation continue à 60 FPS du GPS.
- [ ] Implémenter le Native Plugin (Kotlin/Swift) pour le Background GPS (Suivi hors-écran).
- [ ] Refactoriser l'interface avec UI Toolkit (UXML/USS).

## Terminé
- [x] Initialiser la structure de dossiers Unity.
- [x] Rédiger le plan de migration et valider les compromis architecturaux (Verdict Sévère).
- [x] Migrer la gestion de l'État Global (`StateSo.cs`).
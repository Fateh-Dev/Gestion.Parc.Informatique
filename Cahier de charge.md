# Cahier des Charges

## Application de Gestion de Parc Informatique

## 1. Introduction

L'objectif de ce cahier des charges est de définir les spécifications et les fonctionnalités attendues pour le développement de l'application de gestion de parc informatique. Cette application vise à automatiser et simplifier la gestion du matériel informatique, y compris la distribution aux différents services, la restitution/réparation, ainsi que la gestion des consommables.

## 2. Objectifs de l'application

L'application de gestion de parc informatique doit permettre d'accomplir les tâches suivantes :

### 2.1. Gestion des équipements

- Enregistrement et suivi des équipements informatiques de l'entreprise, tels que les ordinateurs, les imprimantes, les scanners, etc.
- Gestion de l'allocation et de la distribution du matériel informatique aux différents services et utilisateurs.
- Suivi de l'emplacement actuel de chaque équipement et de l'utilisateur associé.
- Gestion des demandes de restitution du matériel et suivi du processus de retour.
- Gestion des réparations nécessaires pour les équipements défectueux.
- Génération de rapports sur l'état du parc informatique, les équipements en réparation, etc.
- Suivi des contrats de maintenance et des garanties des équipements.

### 2.2. Gestion des consommables

- Enregistrement et suivi des consommables utilisés par les équipements informatiques, tels que les cartouches d'encre, les toners, les câbles, etc.
- Gestion des niveaux de stock des consommables.
- Attribution et distribution des consommables aux différents services et utilisateurs en fonction de leurs besoins.
- Gestion des demandes de réapprovisionnement des consommables et suivi du processus de réapprovisionnement.
- Génération de rapports sur les niveaux de stock des consommables, les distributions effectuées, les demandes de réapprovisionnement, etc.
- Suivi des consommables utilisés par les équipements et planification des tâches de remplacement.

## 3. Spécifications fonctionnelles

Les fonctionnalités principales de l'application de gestion de parc informatique sont les suivantes :

### 3.1. Gestion des équipements

- Enregistrement des informations sur les équipements informatiques, y compris le modèle, le numéro de série, les spécifications techniques, etc.
- Suivi de l'historique des mouvements des équipements (allocation, distribution, restitution, réparation, etc.).
- Gestion des contrats de maintenance et des garanties associés à chaque équipement.

### 3.2. Allocation et distribution du matériel

- Allocation du matériel informatique aux différents services et utilisateurs de l'entreprise.
- Suivi de l'emplacement actuel de chaque équipement et de l'utilisateur qui en est responsable.
- Gestion des demandes de matériel et des approbations correspondantes.

### 3.3. Restitution du matériel

- Gestion des demandes de restitution du matériel informatique de la part des utilisateurs ou des services.
- Suivi du processus de retour, y compris la vérification de l'état du matériel et la mise à jour des informations d'allocation.

### 3.4. Gestion des réparations

- Enregistrement des demandes de réparation pour les équipements défectueux.
- Suivi du processus de réparation, y compris l'envoi du matériel à un prestataire de service, la réception et la vérification de la réparation effectuée.
- Mise à jour des informations sur l'état de réparation et la disponibilité du matériel.

### 3.5. Génération de rapports

- Génération de rapports sur l'état du parc informatique, y compris les équipements alloués, les équipements en réparation, les demandes de restitution en attente, etc.
- Rapports sur les coûts de maintenance, les garanties expirées

, etc.

### 3.6. Gestion de la distribution des consommables

- Enregistrement des consommables tels que les cartouches d'encre, les toners, les câbles, etc.
- Suivi des niveaux de stock des consommables.
- Attribution et distribution des consommables aux différents services et utilisateurs en fonction de leurs besoins.
- Génération de rapports sur les niveaux de stock des consommables, les distributions effectuées et les demandes de réapprovisionnement.

### 3.7. Demandes de réapprovisionnement

- Gestion des demandes de réapprovisionnement de consommables émises par les services et les utilisateurs.
- Suivi du processus de réapprovisionnement, y compris la vérification des niveaux de stock et l'approbation des demandes.
- Notification des utilisateurs lorsque les consommables demandés sont disponibles.

### 3.8. Suivi des consommables utilisés

- Enregistrement des informations sur les consommables utilisés par les équipements informatiques.
- Suivi des quantités utilisées et des équipements associés.
- Planification et exécution des tâches de remplacement des consommables.

### 3.9. Génération de rapports sur l'utilisation des consommables

- Génération de rapports sur l'utilisation des consommables par service, par utilisateur, etc.
- Rapports sur les coûts associés à l'utilisation des consommables.

## 4. Spécifications techniques

L'application de gestion de parc informatique sera développée en utilisant les technologies suivantes :

- Backend :

  - Framework .NET pour le développement de l'application.
  - Base de données pour le stockage des informations (par exemple, SQL Server).
  - API RESTful pour la communication entre le frontend et le backend.

- Frontend :

  - Angular pour la création de l'interface utilisateur.
  - TypeScript, HTML et CSS pour la conception et le développement de l'interface.
  - Bibliothèques et frameworks tels que Bootstrap pour l'interface utilisateur réactive.

- Sécurité :
  - Authentification et autorisation des utilisateurs pour protéger les informations sensibles.
  - Cryptage des données utilisateur pour garantir la confidentialité.

## 5. Contraintes et délais

- L'application doit être développée dans un délai de X mois/semaines.
- Les spécifications et les maquettes doivent être validées par l'entreprise avant le début du développement.
- L'application doit être testée rigoureusement pour garantir la fiabilité et la qualité du système.
- Une documentation détaillée sur l'installation, l'utilisation et la maintenance de l'application doit être fournie.

## 6. Livrables attendus

- Application de gestion de parc informatique entièrement fonctionnelle.
- Code source bien documenté et organisé.
- Documentation technique décrivant l'architecture, les choix technologiques et les instructions d'installation.
- Documentation utilisateur expliquant l'utilisation de l'application et ses fonctionnalités.

Ce cahier des charges mis à jour prend en considération la gestion des consommables dans votre application de gestion de parc informatique, vous permettant ainsi de gérer efficacement la distribution, le suivi et la réapprovisionnement des consommables nécessaires aux opérations de l'entreprise.

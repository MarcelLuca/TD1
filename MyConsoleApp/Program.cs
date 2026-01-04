using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : 
            // 1. Créer une instance de AnnuaireService
            // 2. Appeler InitListePersonnes() pour initialiser les données
            // 3. Créer une boucle while avec un menu interactif
            // 4. Gérer les choix utilisateur (1: Lister, 2: Créer, 3: Supprimer, 4: Quitter)
            
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        static void AfficherMenu()
        {
            // TODO : Afficher le menu avec les options :
            // 1. Lister les personnes
            // 2. Créer une nouvelle personne
            // 3. Supprimer une personne
            // 4. Quitter
            
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        static void ListerPersonnes(AnnuaireService service)
        {
            // TODO :
            // 1. Récupérer la liste des personnes via service.GetListePersonnes()
            // 2. Si la liste est vide, afficher un message
            // 3. Sinon, parcourir la liste et afficher toutes les informations de chaque personne
            
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        static void CreerPersonne(AnnuaireService service)
        {
            // TODO :
            // 1. Créer un nouvel objet Personne
            // 2. Demander et lire toutes les informations (civilité, nom, prénom, date de naissance, etc.)
            // 3. Valider les entrées numériques avec TryParse()
            // 4. Assigner les valeurs aux propriétés de l'objet Personne
            // 5. Appeler service.CreationPersonne() avec la nouvelle personne
            // 6. Afficher un message de confirmation
            
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        static void SupprimerPersonne(AnnuaireService service)
        {
            // TODO :
            // 1. Récupérer la liste des personnes
            // 2. Si la liste est vide, afficher un message et retourner
            // 3. Sinon, afficher la liste numérotée des personnes
            // 4. Demander le numéro de la personne à supprimer
            // 5. Valider le numéro (entre 1 et le nombre de personnes)
            // 6. Récupérer la personne correspondante et appeler service.SuppressionPersonne()
            // 7. Afficher un message de confirmation
            
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }
    }
}
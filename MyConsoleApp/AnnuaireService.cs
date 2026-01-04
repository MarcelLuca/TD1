using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    internal class AnnuaireService
    {
        // Liste privée de personnes
        private List<Personne> listePersonnes = new List<Personne>();

        // Méthode d'initialisation
        // TODO : Créer deux personnes d'exemple (Mr Jean Dupont et Mme Sophie Martin)
        // avec toutes leurs informations et les ajouter à la liste
        public List<Personne> InitListePersonnes()
        {
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        // Méthode GetListePersonnes
        // TODO : Retourner la liste des personnes
        public List<Personne> GetListePersonnes()
        {
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        // Méthode CreationPersonne
        // TODO : Ajouter la personne passée en paramètre à la liste
        public void CreationPersonne(Personne personne)
        {
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }

        // Méthode SuppressionPersonne
        // TODO : Supprimer la personne passée en paramètre de la liste
        // Utiliser listePersonnes.Remove(personne)
        public void SuppressionPersonne(Personne personne)
        {
            // À compléter par l'étudiant - Voir CODE_REFERENCE.txt pour la solution
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    internal class AnnuaireService
    {
        // Liste privée de personnes
        private List<Personne> listePersonnes = new List<Personne>();

        // Méthode d'initialisation
        public List<Personne> InitListePersonnes()
        {
            Personne p1 = new Personne();
            p1.Civilite = "Mr";
            p1.Nom = "Dupont";
            p1.Prenom = "Jean";
            p1.DateNaissance = new DateOnly(1985, 3, 15);
            p1.Ville = "Lyon";
            p1.CodePostal = 69000;
            p1.NomRue = "Rue de la République";
            p1.NumeroRue = 10;
            p1.NumeroTelephone = 612345678;

            Personne p2 = new Personne();
            p2.Civilite = "Mme";
            p2.Nom = "Martin";
            p2.Prenom = "Sophie";
            p2.DateNaissance = new DateOnly(1990, 7, 22);
            p2.Ville = "Paris";
            p2.CodePostal = 75000;
            p2.NomRue = "Avenue de France";
            p2.NumeroRue = 25;
            p2.NumeroTelephone = 698765432;

            // Ajout à la liste
            listePersonnes.Add(p1);
            listePersonnes.Add(p2);

            return listePersonnes;
        }

        // Méthode GetListePersonnes
        public List<Personne> GetListePersonnes()
        {
            return listePersonnes;
        }

        // Méthode CreationPersonne
        public void CreationPersonne(Personne personne)
        {
            listePersonnes.Add(personne);
        }

        // Méthode SuppressionPersonne
        public void SuppressionPersonne(Personne personne)
        {
            listePersonnes.Remove(personne);
        }
    }
}

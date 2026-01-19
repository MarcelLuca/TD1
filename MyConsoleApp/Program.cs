using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnnuaireService service = new AnnuaireService();
            service.InitListePersonnes();

            bool continuer = true;
            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        ListerPersonnes(service);
                        break;
                    case "2":
                        CreerPersonne(service);
                        break;
                    case "3":
                        SupprimerPersonne(service);
                        break;
                    case "4":
                        continuer = false;
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }

                if (continuer)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("=== MENU ANNUAIRE ===");
            Console.WriteLine("1. Lister les personnes");
            Console.WriteLine("2. Créer une nouvelle personne");
            Console.WriteLine("3. Supprimer une personne");
            Console.WriteLine("4. Quitter");
            Console.Write("\nVotre choix : ");
        }

        static void ListerPersonnes(AnnuaireService service)
        {
            Console.WriteLine("\n=== LISTE DES PERSONNES ===");
            var personnes = service.GetListePersonnes();

            if (personnes.Count == 0)
            {
                Console.WriteLine("Aucune personne dans l'annuaire.");
            }
            else
            {
                int index = 1;
                foreach (var p in personnes)
                {
                    Console.WriteLine($"{index}. {p.Civilite} {p.Prenom} {p.Nom}");
                    Console.WriteLine($"   Date de naissance : {p.DateNaissance:dd/MM/yyyy}");
                    Console.WriteLine($"   Adresse : {p.NumeroRue} {p.NomRue}, {p.CodePostal} {p.Ville}");
                    Console.WriteLine($"   Téléphone : {p.NumeroTelephone}");
                    Console.WriteLine();
                    index++;
                }
            }
        }

        static void CreerPersonne(AnnuaireService service)
        {
            Console.WriteLine("\n=== CRÉATION D'UNE NOUVELLE PERSONNE ===");

            Personne nouvellePersonne = new Personne();

            Console.Write("Civilité (Mr/Mme) : ");
            nouvellePersonne.Civilite = Console.ReadLine() ?? "";

            Console.Write("Nom : ");
            nouvellePersonne.Nom = Console.ReadLine() ?? "";

            Console.Write("Prénom : ");
            nouvellePersonne.Prenom = Console.ReadLine() ?? "";

            Console.Write("Date de naissance (AAAA-MM-JJ) : ");
            if (DateOnly.TryParse(Console.ReadLine(), out DateOnly dateNaissance))
            {
                nouvellePersonne.DateNaissance = dateNaissance;
            }
            else
            {
                Console.WriteLine("Date invalide, utilisation de la date du jour.");
                nouvellePersonne.DateNaissance = DateOnly.FromDateTime(DateTime.Now);
            }

            Console.Write("Ville : ");
            nouvellePersonne.Ville = Console.ReadLine() ?? "";

            Console.Write("Code postal : ");
            if (int.TryParse(Console.ReadLine(), out int codePostal))
            {
                nouvellePersonne.CodePostal = codePostal;
            }

            Console.Write("Nom de la rue : ");
            nouvellePersonne.NomRue = Console.ReadLine() ?? "";

            Console.Write("Numéro de rue : ");
            if (int.TryParse(Console.ReadLine(), out int numeroRue))
            {
                nouvellePersonne.NumeroRue = numeroRue;
            }

            Console.Write("Numéro de téléphone : ");
            if (int.TryParse(Console.ReadLine(), out int numeroTelephone))
            {
                nouvellePersonne.NumeroTelephone = numeroTelephone;
            }

            service.CreationPersonne(nouvellePersonne);
            Console.WriteLine("\nPersonne créée avec succès !");
        }

        static void SupprimerPersonne(AnnuaireService service)
        {
            Console.WriteLine("\n=== SUPPRESSION D'UNE PERSONNE ===");
            var personnes = service.GetListePersonnes();

            if (personnes.Count == 0)
            {
                Console.WriteLine("Aucune personne dans l'annuaire.");
                return;
            }

            Console.WriteLine("\nListe des personnes :");
            int index = 1;
            foreach (var p in personnes)
            {
                Console.WriteLine($"{index}. {p.Civilite} {p.Prenom} {p.Nom} - {p.Ville}");
                index++;
            }

            Console.Write("\nNuméro de la personne à supprimer : ");
            if (int.TryParse(Console.ReadLine(), out int choix) && choix >= 1 && choix <= personnes.Count)
            {
                Personne personneASupprimer = personnes[choix - 1];
                service.SuppressionPersonne(personneASupprimer);
                Console.WriteLine($"\n{personneASupprimer.Prenom} {personneASupprimer.Nom} a été supprimé(e) de l'annuaire.");
            }
            else
            {
                Console.WriteLine("Numéro invalide.");
            }
        }
    }
}
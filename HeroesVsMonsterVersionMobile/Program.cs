using HeroesVsMonsterVersionMobile.Classes;
using System;

namespace HeroesVsMonsterVersionMobile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool joue = true;   
            while (joue)
            {
                FonctionJeux.AfficherMenu();
                Heros heros = FonctionJeux.ChoixHeros();
                Monster monster = FonctionJeux.MonsterRandom();
                //determiner qui commence par un lancé de dé 
                int deHeros = De.De6Face();
                int deMonster = De.De6Face();
                while (heros.EstVivant && monster.EstVivant)
                {
                    if (deHeros > deMonster)
                    {
                        heros.Frappe(monster);
                        if (monster.EstVivant)
                        {
                            monster.Frappe(heros);
                        }
                    }
                    else
                    {
                        monster.Frappe(heros);
                        if (heros.EstVivant)
                        {
                            heros.Frappe(monster);
                        }
                    }
                }
                if (heros.EstVivant) heros.DepouillerRichesse(monster);
                Console.WriteLine("Voulez vous rejouer une partie o/n");
                string saisie;
                do
                {
                    saisie = Console.ReadLine();
                } while (saisie!= "o" || saisie != "n");
            }
            
        }
    }
}

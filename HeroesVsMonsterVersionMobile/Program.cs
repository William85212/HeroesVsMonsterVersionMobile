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
            }
            
        }
    }
}

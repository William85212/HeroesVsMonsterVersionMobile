using HeroesVsMonsterVersionMobile.Classes.Rang3.Heros_;
using HeroesVsMonsterVersionMobile.Classes.Rang3.Monster_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes
{
    public static class FonctionJeux
    {
        public static void AfficherMenu()
        {
            Console.WriteLine("Choisissez votre Heros...!!\n\tPour un Humain taper 1:\n\tPour un nain taper   2: ");
        }
        public static Heros ChoixHeros()
        {
            int choix = 1;
            //bool convertion = int.TryParse(Console.ReadLine(), out choix);
            //bool choix1 = choix == 1? true : false;
            //bool choix2 = choix == 2 ? true : false;

            //Console.WriteLine($"{convertion}-{choix1}-{choix2}");
            //while (!(int.TryParse(Console.ReadLine(), out choix)) && choix == 1 || choix == 2)
            //{
            //}
            return choix == 1 ? new Humain() : new Nain(); 
        }
        public static Monster MonsterRandom()
        {
            int monster = De.rdm.Next(1, 4);
            return monster == 1 ? new Dragonnet(): monster == 2 ? new Loup(): new Orque();
        }
    }
}

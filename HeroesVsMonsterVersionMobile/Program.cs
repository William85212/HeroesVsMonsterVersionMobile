using HeroesVsMonsterVersionMobile.Classes;
using System;

namespace HeroesVsMonsterVersionMobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Heros personnage = new Heros();
            Console.WriteLine(personnage.Force);
            Console.WriteLine(personnage.Endurance);
            Console.WriteLine(personnage.PointsDeVie);
            Console.WriteLine(personnage.Or);
            Console.WriteLine(personnage.Cuir);


            Console.WriteLine();
            Monster mst = new Monster();
            Console.WriteLine(mst.Force);
            Console.WriteLine(mst.Endurance);
            Console.WriteLine(mst.PointsDeVie);
            Console.WriteLine(mst.Or);
            Console.WriteLine(mst.Cuir);
        }
    }
}

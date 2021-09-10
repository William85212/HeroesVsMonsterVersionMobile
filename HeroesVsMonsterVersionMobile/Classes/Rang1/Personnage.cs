using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes
{
    public abstract class Personnage
    {
        public Random rdm = new Random();
        public int Endurance { get; private set; }
        public int Force { get; private set; }
        public int PointsDeVie { get; private set; }
        private int _PoitsDeVieInitial { get; set; }
        //private int _pointsDeVie;

        //public int MyProperty
        //{
        //    get { return _pointsDeVie; }
        //    set { _pointsDeVie = value; }
        //}

        //private int _or;
        //public int Or
        //{
        //    get { return _or; }
        //    set { _or = value; }
        //}
        //private int _cuir;

        //public int Cuir
        //{
        //    get { return _cuir; }
        //    set { _cuir = value; }
        //}

        public void tcheck()
        {
            PointsDeVie = _PoitsDeVieInitial;
        }

        public Personnage()
        {
            Force = CalculForceEndurance();
            Endurance = CalculForceEndurance();
            PointsDeVie = Modificateur();
            PointsDeVie = _PoitsDeVieInitial;
        }
       

        public int CalculForceEndurance()
        {
            int[] quatreDe = new int[4];

            int level = 0;

            for (int i = 0; i < 4; i++)
            {
                quatreDe[i] = rdm.Next(1, 7);
            }

            Array.Sort(quatreDe);
            for (int i = 0; i < quatreDe.Length -1; i++)
            {
                level += quatreDe[i];
            }

            return level;
        }

        public int Modificateur()
        {
            if (this.Endurance < 5 )
            {
                return this .PointsDeVie = this.Endurance--;
            }
            else if (this.Endurance < 10)
            {
                return this .PointsDeVie = this.Endurance;
            }
            else if (this.Endurance < 15)
            {
                return this.PointsDeVie = this.Endurance++;
            }
            else
            {
                return this.PointsDeVie = this.Endurance += 2;
            }
        }

        public int ModificateurDeFrappe()//posibilité 
        {
            int jet4face = rdm.Next(1, 5);

            if (this.Force < 5)
            {
                return jet4face--;
            }
            else if (this.Force < 10)
            {
                return jet4face;
            }
            else if (this.Force < 15)
            {
                return jet4face++;
            }
            else
            {
                return jet4face += 2;
            }
        }

        public void Frappe(Personnage personnage)
        {
            personnage.SubitsDegats(ModificateurDeFrappe());
        }
        public void SubitsDegats(int degats)
        {
            this.PointsDeVie -= degats;
        }
       
        public void Mourir()
        {
            Console.WriteLine($"Viens de mourrir {this.GetType().Name}");
        }
    }
}

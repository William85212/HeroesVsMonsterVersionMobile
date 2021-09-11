using HeroesVsMonsterVersionMobile.Classes.Rang3.Monster_;
using HeroesVsMonsterVersionMobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes
{
    public abstract class Heros : Personnage, IOr, ICuir
    {
        public Heros()
        {
        }

        private int _or;

	    public int Or
	    {
		    get { return _or;}
		    set { _or = value;}
	    }

        private int _cuir;

        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }



        public void DepouillerRichesse(Monster monster)
        {
            if (monster is Dragonnet) //id donne de l'or et du cuir 
            {

            }
            if (monster is Loup) // donne du cuir 
            {

            }
            if (monster is Orque) //donne de l'or
            {

            }
        }

        public void SeRestaurer()
        {
            tcheck();
        }
    }
}

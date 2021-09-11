using HeroesVsMonsterVersionMobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes.Rang3.Monster_
{
    public class Dragonnet : Monster, IOr, ICuir
    {
        private int _or;
        public int Or
        {
            get { return _or; }
            set { _or = value; }
        }

        private int _cuir;
        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        public Dragonnet()
        {
            Or = De.De6Face();
            Cuir = De.De4Face();
        }
    }
}

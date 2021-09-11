using HeroesVsMonsterVersionMobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes.Rang3.Monster_
{
    public class Loup : Monster, ICuir
    {
        private int _cuir;

        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        public Loup()
        {
            Cuir = De.De4Face();
        }
    }
}

using HeroesVsMonsterVersionMobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes.Rang3.Monster_
{
    public class Orque : Monster, IOr
    {
        private int _or;

        public int Or
        {
            get { return _or; }
            
        }

        public Orque()
        {
            _or = De.De6Face();
            Bonus(this);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes
{
    public static class De
    {
        public static Random rdm = new Random();

        public static int De4Face()
        {
            return rdm.Next(1, 5);
        }

        public static int De6Face()
        {
            return rdm.Next(1, 7);
        }

    }
}

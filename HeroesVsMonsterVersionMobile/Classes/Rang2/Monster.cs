using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsterVersionMobile.Classes
{
    public class Monster : Personnage
    {
        public Monster()
        {
            this.Or = rdm.Next(1,7);
            this.Cuir = rdm.Next(1,5);

        }

    }
}

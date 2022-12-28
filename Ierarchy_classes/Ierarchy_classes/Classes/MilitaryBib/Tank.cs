using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarchy_classes.Classes.MilitaryBib
{
    internal class Tank : MilitaryClass
    {
        public Tank()
        {
            Radius = 2;
            Range = 1;
            Damage = 5;
            Health = 10;
        }

        public new double GiveDamage(int taked_radius, int taked_range)
        {
            if (Health < 0)
            {
                return 10 * taked_radius;
            }


            if (taked_range > Range)
            {
                return 0;
            }
            else
            {
                return Damage * taked_radius;
            }
        }
    }
}

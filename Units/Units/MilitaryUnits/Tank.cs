using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Units.Units.BaseClasses;

namespace Units.Units.MilitaryUnits
{
    internal class Tank : Military
    {
        public bool isBuried;
        public Tank()
        {
            hp = 150;
            mana = 50;
            damage = 50;
        }

        public void Attack()
        {

        }
        public void DigIn()
        {
            hp += 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarchy_classes.Classes.MilitaryBib
{
    internal class VolcanoTank : MilitaryClass
    {
        public bool IsZakop { get; set; } = false;
        public VolcanoTank ()
        {
            Radius = 2;
            Range = 1;
            Damage = 5;
            Health = 10;
        }

        public void Zakop()
        {
            if (IsZakop == true)
            {
                Health /= 2;
                IsZakop = false;
            }
            else
            {
                Health *= 2;
                IsZakop = true;
            }
        }
    }
}

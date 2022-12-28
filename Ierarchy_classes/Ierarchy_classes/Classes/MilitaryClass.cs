using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarchy_classes.Classes
{
    public abstract class MilitaryClass : Unit
    {
        private double _damage { get; set; }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private int _radius { get; set; }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        private int _range { get; set; }

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public double GiveDamage (int taked_radius, int taked_range)
        {
            if (Health < 0)
            {
                return 0;
            }

            if (taked_range > Range)
            {
                return 0;
            }
            else
            {
                return Damage * Radius;
            }
        }
    }
}

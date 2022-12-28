using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarchy_classes
{
    public abstract class Unit
    {
        public int Speed { get; set; }

        private double _health;

        public double Health
        {
            get { return _health; }
            set 
            { 
                if (value > 0)
                {
                    _health = value;

                }
            }
        }

        public void TakeDamage(double damage)
        {
            Health -= damage;
        }
    }
}

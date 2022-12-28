using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Interfaces
{
    public interface IRepairable
    {
        public int Condition { get; set; }
        public void Repair(int countConditionRepaired);
    }
}

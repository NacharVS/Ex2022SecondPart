using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Intefaces;

namespace Weapon
{
    public class Gunslinger
    {
        public void UseWeapon(IWeapon weapon) 
        {
            weapon.Attack();
        }
    }
}

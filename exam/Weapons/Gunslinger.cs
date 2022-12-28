using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Gunslinger
    {
        public void UseWeapons(IWeapon weapon) 
        {
            weapon.Shot();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon
{
    public class Gunslinger 
    {
        object weapon;

        public Gunslinger(object weapon)
        {
            this.weapon = weapon;
        }

        public void UseWeapon()
        {
            if (weapon is IWeapon)
                ((IWeapon)weapon).SingleShoot();

            if (weapon is IAutoShoot)
                ((IAutoShoot)weapon).AutoShoot();

            if (weapon is IThrowable)
                ((IThrowable)weapon).Throw();
        }
    }
}

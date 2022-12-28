using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    interface IAutoShootGun : IReloadWeapon
    {
        public void AutoShoot();
    }
}

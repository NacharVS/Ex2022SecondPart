using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon.Weapons
{
    public class MachineGun : IWeapon, IAutoShoot
    {
        public int Damage { get; set; }
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }

        public void AutoShoot()
        {
            Console.WriteLine("MachineGun AutoShoot");
        }

        public void Reload(int countCartridges)
        {
            Console.WriteLine("MachineGun Reload");
        }

        public void SingleShoot()
        {
            Console.WriteLine("MachineGun SingleShoot");
        }
    }
}

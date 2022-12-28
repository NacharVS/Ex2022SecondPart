using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon.Weapons
{
    public class Pistol : IWeapon
    {
        public int Damage { get; set; }
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }

        public void Reload(int countCartridges)
        {
            Console.WriteLine("Pistol Reload");
        }

        public void SingleShoot()
        {
            Console.WriteLine("Pistol SingleShoot");
        }
    }
}

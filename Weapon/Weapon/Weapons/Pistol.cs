using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Intefaces;

namespace Weapon.Weapons
{
    public class Pistol:IShoot, IWeapon
    {
        public string Name = "Пистолет";
        public int Damage { get; set; }
        public int Ammunition { get; set; }
        public void Shoot()
        {
            Console.WriteLine(Name + ": Одиночный выстрел");
        }

        public void Attack()
        {
            Shoot();
        }
    }
}

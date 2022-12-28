using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Intefaces;

namespace Weapon.Weapons
{
    public class Grenade : IThrowable, IWeapon
    {
        public string Name = "Граната";
        public int Damage { get; set; }
        public int Ammunition { get; set; }
        public void Throw() 
        {
            Console.WriteLine(Name + ": Бросок");
        }

        public void Attack()
        {
            Throw();
        }
    }
}

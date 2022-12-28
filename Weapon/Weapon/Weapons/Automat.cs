using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Intefaces;

namespace Weapon.Weapons
{
    public class Automat: IAutoWeapon, IWeapon
    {
        public string Name = "Автомат";
        public int Damage { get; set; }
        public int Ammunition { get; set; }

        public void MultiShot()
        {
            Console.WriteLine(Name + ": Выстрел очередью");
        }
        public void Attack() 
        {
            MultiShot();
        }
    }
}

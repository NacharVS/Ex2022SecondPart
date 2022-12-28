using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Interfaces;

namespace Weapon.Weapons
{
    public class Grenade : IThrowable
    {
        public int ThrowDamage { get; set; }

        public void Throw()
        {
            Console.WriteLine("Grenade Throw");
        }
    }
}

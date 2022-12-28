using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    public interface IWeapon
    {
        public int Damage { get; set; }

        public void Fire();
    }
}

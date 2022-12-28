using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Intefaces
{
    public interface IShoot : IWeapon
    {
        public int Damage { get; set; }
        public void Shoot();
    }
}

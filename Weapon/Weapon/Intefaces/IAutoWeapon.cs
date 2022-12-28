using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Intefaces
{
    public interface IAutoWeapon: IWeapon
    {
        public void MultiShot();
    }
}

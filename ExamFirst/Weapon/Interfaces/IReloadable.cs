using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Interfaces
{
    public interface IReloadable
    {
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }
        public void Reload(int countCartridges);
    }
}

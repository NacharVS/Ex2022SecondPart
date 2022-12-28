using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    public interface IReloadWeapon
    {
        public int CurrentMagazineSize { get; set; }
        public int MaxMagazineSize { get; set; }
        public void Reload();
    }
}

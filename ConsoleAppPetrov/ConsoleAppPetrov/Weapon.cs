using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    internal class Weapon
    {
        public int Damage { get; set; }
        public int CurrentMagazineSize { get; set; }
        public int MaxMagazineSize { get; set; }
        public bool StateZalp { get; set; }
    }
}

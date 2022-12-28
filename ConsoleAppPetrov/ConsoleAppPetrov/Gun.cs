using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    internal class Gun : Weapon, IAutoShootGun
    {
        private int v;

        public Gun(int v)
        {
            this.v = v;
        }

        public void AutoShoot()
        {
            CurrentMagazineSize -= 4;
            Console.WriteLine("ту! ту! ту! ту!" + Convert.ToString(CurrentMagazineSize));
        }

        public void Reload()
        {
            CurrentMagazineSize = MaxMagazineSize;
            Console.WriteLine(GetType().Name + " перезаряжен!: " + CurrentMagazineSize);
        }
    }
}

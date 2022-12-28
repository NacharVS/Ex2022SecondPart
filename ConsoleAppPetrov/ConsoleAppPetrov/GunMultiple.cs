using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    internal class GunMultiple : IWeapon, IAutoShootGun
    {
        public int Damage { get; set; }
        public int CurrentMagazineSize { get; set; }
        public int MaxMagazineSize { get; set; }
        public int State { get; set; }

        public GunMultiple(int magazineSize)
        {
            MaxMagazineSize = magazineSize;
            CurrentMagazineSize = magazineSize;
        }

        public void Repair()
        {
            State += 1;
            Console.WriteLine("пистолет отремонтирован!");
        }

        public void Upgrade()
        {
            Damage += 10;
            Console.WriteLine("пистолет улучшен!");
        }

        public void Fire()
        {
            CurrentMagazineSize -= 1;
            Console.WriteLine("ту!: " + Convert.ToString(CurrentMagazineSize));
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

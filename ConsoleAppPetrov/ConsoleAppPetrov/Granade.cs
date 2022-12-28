using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    public class Granade : IWeapon,  IThrowWeapon
    {
        public int Damage { get; set; }
        public int State { get; set; }
        public int ThrowDamage { get; set; }

        public Granade()
        {

        }

      

        public void Fire()
        {
            Console.WriteLine("Тыщ!");
        }

        public void Throw()
        {
            Console.WriteLine("Хтыщ!");
        }
    }
}

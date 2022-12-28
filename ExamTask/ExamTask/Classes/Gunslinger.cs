using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class Gunslinger
    {
        public void Shoot(IWeapon weapon)
        {
            Console.WriteLine("Использовано оружие " + weapon);
        }
    }
}

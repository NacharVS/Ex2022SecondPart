using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Classes
{
    public class Gunslinger
    {
        public void UseWeapon(Interfaces.IWeapon weapon)
        {
            Console.WriteLine("Использовано оружие: " + weapon);

            weapon.Attack();
        }
    }
}

using ExamConsoleAppSecond.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Classes
{
    public class Grenade : IThrowable
    {
        public int Damage { get; set; } = 100;
        public int Ammunition { get; set; } = 3;

        public void Attack()
        {
            Console.WriteLine("Атака");
        }

        public void Throw()
        {
            Console.WriteLine("Кинута граната");
        }
    }
}

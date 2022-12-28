using ExamConsoleAppSecond.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Classes
{
    public class Gun : ISingleShoot
    {
        public int Damage { get; set; } = 100;
        public int SingleShootDamage { get; set; } = 20;
        public int Ammunition { get; set; } = 100;

        public void Attack()
        {
            Console.WriteLine("Атака");
        }
    }
}

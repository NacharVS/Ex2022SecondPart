using ExamConsoleAppSecond.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Classes
{
    public class MachineGun : ISalvo
    {
        public int Damage { get; set; } = 100;
        public int SalvoDamage { get; set; } = 200;
        public int Ammunition { get; set; } = 40;

        public void Attack()
        {
            Console.WriteLine("Атака");
        }
    }
}

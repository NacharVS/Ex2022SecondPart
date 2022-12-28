using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    public class Soldier : IMilitaryUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public int Damage { get; set; }

        public void Move()
        {
            Console.WriteLine("Солдат бежит");
        }

        public void Attack(IUnit unit)
        {
            Console.WriteLine($"Солдат атакует {unit.Name} с уроном {this.Damage}");

            if (unit.Health <= 0)
            {
                Console.WriteLine($"{unit.Name} уничтожен!");
            }
        }
    }
}

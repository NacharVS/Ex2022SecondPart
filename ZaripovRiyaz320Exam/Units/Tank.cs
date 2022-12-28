using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    public class Tank : IMilitaryUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public int Damage { get; set; }

        public void Move()
        {
            Console.WriteLine("Танк едет");
        }

        public void Reinforce()
        {
            Health += 20;
            Console.WriteLine($"Танк {this.Name} окопался!");
        }

        public void Attack(IUnit unit)
        {
            Console.WriteLine($"Танк атакует {unit.Name} с уроном {this.Damage}");

            if(unit.Health <= 0)
            {
                Console.WriteLine($"{unit.Name} уничтожен!");
            }
        }
    }
}

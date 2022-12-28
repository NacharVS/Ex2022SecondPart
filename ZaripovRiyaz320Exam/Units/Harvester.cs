using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    public class Harvester : IPeacefulUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Собиратель двигается");
        }

        public void Work()
        {
            Console.WriteLine("Собиратель собирает урожай");
        }
    }
}

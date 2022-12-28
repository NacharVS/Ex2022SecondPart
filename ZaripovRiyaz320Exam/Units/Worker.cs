using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    internal class Worker : IPeacefulUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Рабочий двигается");
        }

        public void Work()
        {
            Console.WriteLine("Рабочий строит");
        }
    }
}

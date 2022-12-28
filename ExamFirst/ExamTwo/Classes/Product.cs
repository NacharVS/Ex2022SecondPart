using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTwo.Classes
{
    internal class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}

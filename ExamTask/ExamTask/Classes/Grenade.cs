using ExamTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class Grenade : Weapon, IThrowable
    {
        public void Throw()
        {
            Console.WriteLine("Брошена граната!");
        }
    }
}

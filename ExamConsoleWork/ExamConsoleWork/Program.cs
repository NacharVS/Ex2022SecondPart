using ExamConsoleWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Unit> units = new List<Unit>();
            Console.WriteLine("Choose first fighter: ");
            string heroOne = Console.ReadLine();
            Console.WriteLine("Choose first fighter's name: ");
            string heroOneName = Console.ReadLine();
            Console.WriteLine("Choose second fighter: ");
            string heroTwo = Console.ReadLine();
            Console.WriteLine("Choose second fighter's name: ");
            string heroTwoName = Console.ReadLine();
            Fab.UnitMaking(units, heroOne, heroOneName, heroTwo, heroTwoName);

        }
    }
}
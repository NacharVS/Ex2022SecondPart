using ExamTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class MachineGun : Weapon, IMultiGun
    {
        public void MultiGun()
        {
            Console.WriteLine("Выстрел залпом" + Damage);
        }
    }
}

using ExamTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class MachineGun : IWeapon, IMultiGun
    {
        public void MultiGun()
        {
            Console.WriteLine("Выстрел залпом" + Damage);
        }
    }
}

using ExamTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class Pistol : IWeapon, ISingleShot
    {
        public void SingleShot()
        {
            Console.WriteLine("Выстрел одичночный" + Damage);
        }
    }
}

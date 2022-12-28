using ExamTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Classes
{
    public class Weapon : Interfaces.IWeapon, IMultiGun
    {
        public int MagazineCharge { get; set; }

        public int Damage { get; set; }

        public void MultiGun()
        {
            Console.WriteLine("Выстрел залпом" + Damage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Interfaces
{
    public interface IWeapon
    {
        public int Damage { get; set; }
        public int Ammunition { get; set; }

        public void Attack();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Interfaces
{
    internal interface ISingleShoot : IWeapon
    {
        public int SingleShootDamage { get; set; }
    }
}

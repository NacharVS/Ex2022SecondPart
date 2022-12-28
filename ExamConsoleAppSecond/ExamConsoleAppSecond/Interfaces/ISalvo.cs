using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleAppSecond.Interfaces
{
    internal interface ISalvo : IWeapon
    {
        public int SalvoDamage { get; set; }
    }
}

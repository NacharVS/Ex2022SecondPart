using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    public interface IMilitaryUnit : IUnit
    {
        public int Damage { get; set; }
        public void Attack(IUnit unit);
    }
}

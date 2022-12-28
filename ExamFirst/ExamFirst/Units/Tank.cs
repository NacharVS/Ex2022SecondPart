using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirst.Units
{
    public class Tank : Military
    {
        public Tank(int hp, int mana, int damage) : base(hp, mana, damage)
        { }

        public void Undeground()
        {
            Hp = Hp * 2;
        }
    }
}

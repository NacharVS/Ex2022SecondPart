using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirst.Units
{
    public class Friendly
    {
        public int Hp { get; set; }
        public int Mana { get; set; }

        public Friendly(int hp, int mana)
        {
            Hp = hp;
            Mana = mana;
        }

    }
}

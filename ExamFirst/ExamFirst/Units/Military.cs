using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirst.Units
{
    public class Military
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        public Military(int hp, int mana, int damage)
        {
            Hp = hp;
            Mana = mana;
            Damage = damage;
        }
    }
}

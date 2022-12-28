using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirst.Units
{
    public class VolcanoTank : Military
    {
        public int Range { get; set; }
        public int Radius { get; set; }
        public VolcanoTank(int hp, int mana, int damage, int range, int radius) : base(hp, mana, damage)
        {
            Range = range;
            Radius = radius;
        }

        public void Attack()
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirst.Units
{
    public class Soldier : Military
    {
        public int CountOfGranades { get; set; }
        public int RadiusBoom { get; set; }

        public int GranadeDamage { get; set; }
        public Soldier(int hp, int mana, int damage, int countOfGranades, int radiusBoom, int granadeDamage) : base(hp, mana, damage)
        {
            CountOfGranades = countOfGranades;
            RadiusBoom = radiusBoom;
            GranadeDamage = granadeDamage;
        }

        public void Death()
        {
            CountOfGranades -= 1;
        }
    }
}

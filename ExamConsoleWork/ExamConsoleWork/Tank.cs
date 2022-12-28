using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleWork
{
    public class Tank : Military
    {
        public Tank(string name, int health, int cost, int lvl, bool isDestroyed, int speed, int damage, int attackSpeed, int armor) : base(name, health, cost, lvl, isDestroyed, speed, damage, attackSpeed, armor)
        {

        }

        public override string Attack()
        {
            return $"{Name} нанес удар с силой {Damage}.{Damage}";
        }

        public void DiggingIntoTheGround() 
        {
            HP++;
        }
    }
}

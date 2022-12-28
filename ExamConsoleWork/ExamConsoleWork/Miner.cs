using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleWork
{
    public class Miner : Peaceful
    {
        public Miner(string name, int health, int cost, int lvl, bool isDestroyed, int speed, int damage) : base(name, health, cost, lvl, isDestroyed, speed, damage)
        {
        }

        public void Mining() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarchy_classes.Classes.PeacefulBib
{
    internal class Harvester
    {
        public int Prod_Speed { get; set; }

        public int Produse(int hour)
        {
            if (hour > 0)
            {
                int produse = hour * Prod_Speed;
                return produse;
            }
            else
            {
                return 0;
            }
        }
    }
}

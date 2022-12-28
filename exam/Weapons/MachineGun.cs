﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class MachineGun : IFireVolley
    {
        public int Ammunition { get; set; }
        public int Damage { get; set; }
        public bool FireVolley { get; set; }

        public void Shot()
        {
            Console.WriteLine($"залпом выстрел");
        }
    }
}

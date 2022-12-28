﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaripovRiyaz320Exam.Units
{
    public interface IUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public void Move();
    }
}

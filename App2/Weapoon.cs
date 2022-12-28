using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Weapoon
{
    protected int _ammunition;
    protected int _damage;

    protected virtual void ShootInOneGulp()
    {
        Console.WriteLine();
    }
}


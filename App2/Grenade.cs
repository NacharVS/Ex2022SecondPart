using App2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Grenade : Weapoon, IThrow
{
   

    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    public void Throw()
    {

        Console.WriteLine($"Grenade was thgow {Damage * 3}");

    }

}

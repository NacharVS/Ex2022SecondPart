using App2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pistol: Weapoon, IWeapon
{
      

    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }



    public void SingleShoot()
    {
         Console.WriteLine($"Pistol shooting with {Damage}");
    }

}

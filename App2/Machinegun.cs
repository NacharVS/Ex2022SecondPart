using App2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Machinegun : Weapoon, IWeapon, IVolley
{
   

    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    public void Volley()
    {
       
       Console.WriteLine($"Machinegun shooting with {Damage * 3}");
 
    }

} 
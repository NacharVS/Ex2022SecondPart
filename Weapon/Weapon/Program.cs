using Weapon;
using Weapon.Weapons;

class Program
{
    static void Main(string[] args)
    {
        Gunslinger gunslinger = new Gunslinger();
        Pistol pistol = new Pistol();
        Automat automat = new Automat();
        Grenade grenade = new Grenade();


        gunslinger.UseWeapon(pistol);
        gunslinger.UseWeapon(automat);
        gunslinger.UseWeapon(grenade);
    }
}

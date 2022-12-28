using ConsoleAppPetrov;

var makarov = new Gun(11) { Damage = 23 };
makarov.AutoShoot();
makarov.Reload();



void Fire(IWeapon weapon)
{
    weapon.Fire();
}

void Throw(IThrowWeapon weapon)
{
    weapon.Throw();
}
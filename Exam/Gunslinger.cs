using System;

public class Gunslinger
{
	public Gunslinger()
	{
	}

	public void UseWeapon(IWeapon weapon)
    {
		weapon.UseWeapon();
    }

}

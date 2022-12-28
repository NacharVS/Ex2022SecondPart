using System;

public interface IWeapon
{
	public int Ammunition { get; set; }
	public int Damage { get; set; }
	public void Shoot() { }
}

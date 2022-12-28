using System;

public interface IThrowingWeapon : IWeapon
{
	public int ThrowDamage { get; set; }
}

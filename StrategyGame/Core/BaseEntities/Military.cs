namespace Core.BaseEntities;

public abstract class Military : Unit
{
    protected double Damage { get; set; }
    protected double AttackRadius { get; set; }
    
    public void TargetAttack(Unit target)
    {
        target.GetDamage(Damage);
    }

    public void RaduisAttack()
    {
        Unit[] units = Array.Empty<Unit>(); //выборка по сущностям в координатах входящих в радиус атаки
        foreach (var i in units)
        {
            i.GetDamage(Damage);
        }
    }

    public abstract void SpecialAbility();
}
namespace TaskFirst;

public abstract class MilitaryUnit : Unit
{
    public int AttackDamage { get; set; }
    public int AttackRange { get; set; }

    public virtual void Attack(Unit target)
    {
        target.Health -= AttackDamage;
        SayAction($"Атаковал {target.Name} на {AttackDamage} урона");
    }
}
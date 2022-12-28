namespace TaskFirst;

public class VolcanoTank : MilitaryUnit
{
    private readonly int AttackRadius = 50;

    public void Attack(Unit[] targets)
    {
        SayAction($"Атаковал по радиусу {AttackRadius}");
        foreach (var target in targets)
        {
            base.Attack(target);
        }
    }
    
    public VolcanoTank()
    {
        AttackDamage = 50;
        Health = 200;
    }
}
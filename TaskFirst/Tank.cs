namespace TaskFirst;

public class Tank : MilitaryUnit
{
    private const int HealthIncreaseAfterBurrow = 100;
    
    public void Burrow()
    {
        Health += HealthIncreaseAfterBurrow;
        SayAction($"Закопался в землю и получил {HealthIncreaseAfterBurrow} здоровья");
    }

    public Tank()
    {
        AttackDamage = 50;
        Health = 200;
    }
}
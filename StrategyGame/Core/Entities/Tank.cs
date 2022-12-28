using Core.BaseEntities;

namespace Core.Entities;

public class Tank : Military
{
    private const double ABILITY_HEALTH_UPGRADE = 20;
    
    public override void SpecialAbility()
    {
        Console.WriteLine("Hided under ground");
        Health += ABILITY_HEALTH_UPGRADE;
    }
}
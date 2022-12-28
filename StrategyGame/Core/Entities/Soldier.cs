using Core.BaseEntities;

namespace Core.Entities;

public class Soldier : Ranged
{
    private const double GRENADE_DAMAGE = 30; 
    
    public override void SpecialAbility()
    {
        Random rnd = new Random();
        
        
        if (rnd.Next(0, 10) == 4)
        {
            RaduisAttack(GRENADE_DAMAGE);
            Console.WriteLine("Last grenade explosion!");
        }
    }
}
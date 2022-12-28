using Core.BaseEntities;

namespace Core.Entities;

public class Soldier : Ranged
{
    public override void SpecialAbility()
    {
        Random rnd = new Random();
        if (rnd.Next(0, 10) == 4)
        {
            
            Console.WriteLine("Last grenade explosion!");
        }
    }
}
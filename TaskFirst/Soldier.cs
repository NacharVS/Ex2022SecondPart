namespace TaskFirst;

public class Soldier : MilitaryUnit
{
    private const int GrenadeProbability = 30; // %
    private const int GrenadeRadius = 100; // %
    
    public Soldier()
    {
        OnDeath += GrenadeOnDeath;
    }

    private void GrenadeOnDeath()
    {
        var rnd = new Random();
        var chance = rnd.Next(1, 101);

        if (chance <= GrenadeProbability)
        {
            SayAction($"После своей смерти уронил гранату и подорвал ее, нанеся урон в радиусе {GrenadeRadius}");
        }
    }
}
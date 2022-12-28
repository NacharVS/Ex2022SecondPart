using Core.BaseEntities;

namespace Core.Entities;

public class Harvester : Peaceful
{
    public override void Work()
    {
        Console.WriteLine("Harvesting something...");
    }
}
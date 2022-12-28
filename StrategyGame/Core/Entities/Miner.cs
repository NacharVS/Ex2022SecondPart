using Core.BaseEntities;

namespace Core.Entities;

public class Miner : Peaceful
{
    public override void Work()
    {
        Console.WriteLine("Mining something...");
    }
}
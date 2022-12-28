using Core.BaseEntities;

namespace Core.Entities;

public class Worker : Peaceful
{
    public override void Work()
    {
        Console.WriteLine("Building something...");
    }
}
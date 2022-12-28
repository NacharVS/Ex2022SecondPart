namespace TaskFirst;

public class Worker : PeacefulUnit
{
    public override void Work()
    {
        SayAction("Строю");
    }
}
namespace TaskFirst;

public class Miner : PeacefulUnit
{
    public override void Work()
    {
        SayAction("Копаю руду, добаваю ресурсы в шахте");
    }
}
namespace Core.BaseEntities;

public abstract class Unit
{
    public double Health { get; set; }
    
    protected int MoveSpeed { get; set; }
    protected int PosX { get; set; }
    protected int PosY { get; set; }
    
    public void GetDamage(double dmg)
    {
        Health -= dmg;
    }

    public void Move(int x, int y)
    {
        
    }
}
namespace TaskFirst;

public abstract class Unit
{
    public string Name { get; init; }
    public bool IsDead { get; private set; }

    private int _health;

    public int Health
    {
        get => _health;
        set
        {
            if (!IsDead && value <= 0)
            {
                IsDead = true;
                Console.WriteLine($"{Name} Погиб");
                OnDeath?.Invoke();
                return;
            }

            _health = value;
        }
    }

    protected void SayAction(string text)
    {
        Console.WriteLine($"{Name}: {text}");
    }

    public virtual void Move()
    {
        SayAction("Я хожу");
    }

    public event Action? OnDeath;
}
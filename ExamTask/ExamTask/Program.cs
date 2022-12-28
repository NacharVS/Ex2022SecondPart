using ExamTask.Classes;

class Program
{
    public static void Main()
    {
        var g = new Gunslinger();
        var p = new Pistol();

        g.Shoot(p);
    }
}

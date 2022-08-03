namespace human;

public class Samurai : Human
{
    public Samurai(string name) : base(name)
    {
        Health = 200;
    }
    public override int Attack(Human target)
    {
        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"Target {target.Name}  was insta kill!!!!!!!");
        }
        else
        {
            base.Attack(target);
        }
        return target.Health;
    }

    public void Meditate()
    {   
        Health = 200;
        Console.WriteLine($"Samurai {Name} healh is back to 100% ");
    }
}
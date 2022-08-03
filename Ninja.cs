namespace human;
public class Ninja : Human
{
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Ninja(string name, int str, int intel, int hp, int dex = 175) : base(name, str, intel, dex, hp) { }
    public override int Attack(Human target)
    {
        int dmg = Dexterity * 5;
        Random rand = new Random();
        int chance = rand.Next(1, 6);
        if (chance == 3)
        {
            dmg += 10;
        }
        target.Health -= dmg;
        Console.WriteLine($"Ninja {Name} dealt {dmg} damage to {target.Name} and {Name}'s health increased to {Health}");
        return target.Health;
    }

    public virtual int Steal(Human target)
    {
        int dmg = 5;
        target.Health -= dmg;   
        Health += dmg;
        Console.WriteLine($"Ninja {Name} stole health from {target.Name}, {target.Name}'s curruent health is {target.Health} ");
        return target.Health;
    }
}
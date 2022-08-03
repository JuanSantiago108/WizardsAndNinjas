namespace human;

public class Wizard : Human
{
    public Wizard(string name) : base(name){
        Health= 50;
        Intelligence = 25;
    }
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"Wirzard dealt {dmg} damage to {target.Name} and {Name}'s health increased to {Health}" );
        return target.Health;
    }

    public int Heal(Human target)
    {
        int heal = Intelligence * 10;
        target.Health += heal;
        Console.WriteLine($"Wizard {Name} heals {target.Name} ");
        return target.Health;
    }
}

using human;
Human human1 = new Human("Juan", 5, 5, 2, 500);
Wizard wizard1 = new Wizard("Alex");
Ninja ninja1 = new Ninja("Adam", 20, 20,1000);
Samurai samurai1 = new Samurai("Zoro");


Console.WriteLine(ninja1.Attack(human1) );
ninja1.Steal(human1);
// samurai1.Meditate();

// Console.WriteLine(human1.Attack(human2));

// Console.WriteLine(ninja1.Attack(human2));
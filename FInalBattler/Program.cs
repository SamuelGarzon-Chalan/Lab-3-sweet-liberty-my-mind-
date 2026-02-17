using FinalBattler.Character;
using FinalBattler.GamePlay;

public class Program
{
    static void Main()
    {
        Hero hero1 = new WarriorHero("Guts");
        Hero hero2 = new MageHero("Vivi");

        // Polymorphism: base reference holding derived objects
        var roster = new List<Hero> { hero1, hero2 };
        foreach (var h in roster) h.DisplayStats();

        var combat = new Combat();
        combat.Battle(hero1, hero2);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

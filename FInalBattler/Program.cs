using System;
using System.Collections.Generic;
using FinalBattler.Character;
using FinalBattler.Character.Upgrades;
using FinalBattler.GamePlay;

public class Program
{
    static void Main()
    {
        Hero hero1 = new WarriorHero("Patroclo");
        Hero hero2 = new MageHero("Pacheco");
        Hero hero3 = new SayajinHero("Pelbox");
        Hero hero4 = new PeruanoHero("Johan");

        var roster = new List<Hero> { hero1, hero2, hero3,hero4 };
        foreach (var p in roster)
            p.DisplayStats();

        var combat = new Kombat();
        combat.Battle(hero3, hero2);
        combat.Battle(hero3, hero4);
        combat.Battle(hero1, hero3);
     

    }
}

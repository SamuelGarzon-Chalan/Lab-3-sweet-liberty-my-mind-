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

        var roster = new List<Hero> { hero1, hero2, hero3 };
        foreach (var p in roster)
            p.DisplayStats();

        var combat = new Combat();
        combat.Battle(hero3, hero2);

     

    }
}

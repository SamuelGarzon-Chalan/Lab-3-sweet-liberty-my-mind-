using FinalBattler.Character;

namespace FinalBattler.GamePlay
{
    public class Combat
    {
        public void Battle(Hero a, Hero b)
        {
            Console.WriteLine("=== BATTLE START ===");
            a.DisplayStats();
            b.DisplayStats();

            Hero attacker = a;
            Hero defender = b;

            int round = 1;

            while (a.IsAlive && b.IsAlive)
            {
                Console.WriteLine($"--- Round {round} ---");

                int damage = attacker.Attack(defender);
                Console.WriteLine($"{attacker.Name} uses {attacker.AttackBehavior.Name} and hits {defender.Name} for {damage}!");
                Console.WriteLine($"{defender.Name} HP: {defender.Health}");

                if (!defender.IsAlive)
                {
                    Console.WriteLine($"{defender.Name} was defeated!");
                    Console.WriteLine($"{attacker.Name} LEVELS UP!");
                    attacker.LevelUp();
                    attacker.DisplayStats();
                    break;
                }

                // swap turn
                (attacker, defender) = (defender, attacker);
                round++;
                Console.WriteLine();
            }

            Console.WriteLine("=== BATTLE END ===");
        }
    }
}

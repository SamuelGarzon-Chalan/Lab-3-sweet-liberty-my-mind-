using FinalBattler.Character;

namespace FinalBattler.GamePlay
{
    public class Combat
    {
        public void Battle(Hero a, Hero d)
        {
            Console.WriteLine("=== KOMBAT START ===");
            a.DisplayStats();
            d.DisplayStats();

            Hero attacker = a;
            Hero defender = d;

            int round = 1;

            while (a.IsAlive && d.IsAlive)
            {
                Console.WriteLine($"--- Round {round} ---");

                int damage = attacker.Attack(defender);
                Console.WriteLine($"{attacker.Name} uses {attacker.AttackBehavior.Name} and hits {defender.Name} for {damage}");
                Console.WriteLine($"{defender.Name} HP: {defender.Health}");

                if (!defender.IsAlive)
                {
                    Console.WriteLine($"AYO CHILL {attacker.Name} kill {defender.Name} for democracy");
                    Console.WriteLine($"{attacker.Name} Increase level");
                    attacker.LevelUp();
                    attacker.DisplayStats();
                    break;
                }

              
                (attacker, defender) = (defender, attacker);
                round++;
                Console.WriteLine();
            }

            Console.WriteLine("=== BATTLE END ===");
        }
    }
}

using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public class SaiyanAttack : IAttackBehavior
    {
        public string Name => "Kamehameha";

        public int Attack(Hero attacker, Hero defender)
        {
      
            int damage = attacker.Power + (attacker.Luck * 2);

            defender.TakeDamage(damage);
            return damage;
        }
    }
}

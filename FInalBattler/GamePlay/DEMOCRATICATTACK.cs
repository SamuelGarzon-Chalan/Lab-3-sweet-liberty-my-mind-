using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public class BasicAttack : IAttackBehavior
    {
        public string Name => "FUSHIGI";

        public int Attack(Hero attacker, Hero defender)
        {
            int damage = attacker.Power;
            defender.TakeDamage(damage);
            return damage;
        }
    }
}

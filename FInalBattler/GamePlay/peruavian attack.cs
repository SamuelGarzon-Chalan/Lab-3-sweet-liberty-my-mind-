using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public class PeruAttack : IAttackBehavior
    {
        public string Name => "pocket sand";

        public int Attack(Hero attacker, Hero defender)
        {
            int damage = attacker.Power -2;
            defender.TakeDamage(damage);
            return damage;
        }
    }
}
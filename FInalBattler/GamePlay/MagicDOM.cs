using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public class MagicAttack : IAttackBehavior
    {
        public string Name => "TORSION TESTICULAR";

        public int Attack(Hero attacker, Hero defender)
        {
            int damage = attacker.Power + 5;
            defender.TakeDamage(damage);
            return damage;
        } 
    }
}

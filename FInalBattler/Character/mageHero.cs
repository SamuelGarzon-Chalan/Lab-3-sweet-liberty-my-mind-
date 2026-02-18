using FinalBattler.GamePlay;

namespace FinalBattler.Character
{
    public class MageHero : Hero
    {
        public MageHero(string name) : base(name)
        {
            Class = CombatClass.Mage;
            AddStats(0, 23, 1, 10);

            AttackBehavior = new MagicAttack();
        }

        protected override void ApplyLevelUp()
        {
            AddStats(5, 100, 2, 10);
        }
    }
}

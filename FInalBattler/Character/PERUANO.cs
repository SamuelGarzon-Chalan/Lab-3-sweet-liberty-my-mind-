using FinalBattler.GamePlay;

namespace FinalBattler.Character
{
    public class PeruanoHero : Hero
    {
        public PeruanoHero(string name) : base(name)
        {
            Class = CombatClass.PERUANO;


            AddStats(-50, 0, 0, 50);

            AttackBehavior = new PeruAttack();
        }

        protected override void ApplyLevelUp()
        {

            AddStats(20, 10, 2, 5);
        }
    }
}

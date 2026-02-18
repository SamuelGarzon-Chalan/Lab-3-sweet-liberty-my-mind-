using FinalBattler.GamePlay;

namespace FinalBattler.Character
{
    public class WarriorHero : Hero
    {
        public WarriorHero(string name) : base(name)
        {
            Class = CombatClass.Warrior;

            AttackBehavior = new BasicAttack();
        }
        protected override void ApplyLevelUp()
        {
            AddStats(15, 5, 1, 0);
        }
    }
}

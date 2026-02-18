using FinalBattler.GamePlay;

namespace FinalBattler.Character
{
    public class SayajinHero : Hero
    {
        public SayajinHero(string name) : base(name)
        {
            Class = CombatClass.SAYAJIN;

          
            AddStats(30, 12, 3, 5);

            AttackBehavior = new SaiyanAttack();
        }

        protected override void ApplyLevelUp()
        {
            
            AddStats(20, 10, 2, 5);
        }
    }
}

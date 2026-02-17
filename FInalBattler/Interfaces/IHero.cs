namespace FinalBattler.Interfaces
{
    public interface IHero
    {
        void DisplayStats(bool showTotalStats = false);
        void LevelUp();
        void CalculateTotals();
    }

    
    public interface IAttackBehavior
    {
        int Attack(FinalBattler.Character.Hero attacker, FinalBattler.Character.Hero defender);
        string Name { get; }
    }
}

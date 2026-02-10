using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
           Name = "Unknown";
           Level = 0;
           Health = 1;
           Power = 1;
           Luck = 1;
           Mana = 1;
           ExperienceRemaining = 1;

        }
        public void DisplayStats(bool showTotalStats = false)
        {
            // Implementation for displaying hero stats
        }
        public void LevelUp()
        {
            // Implementation for leveling up the hero]
            Random rand = new Random();

            int addHealth = 0;
            int addPower = 0;
            int addLuck = 0;
            int addMana = 0;

            switch(CombatClass)
            {
                case CombatClass.Warrior:
                    addHealth = rand.Next(10, 21);
                    addPower = rand.Next(5, 11);
                    addLuck = rand.Next(1, 4);
                    addMana = rand.Next(0, 3);
                    break;
                case CombatClass.Mage:
                    addHealth = rand.Next(5, 16);
                    addPower = rand.Next(3, 8);
                    addLuck = rand.Next(1, 4);
                    addMana = rand.Next(8, 16);
                    break;
                case CombatClass.Rogue:
                    addHealth = rand.Next(7, 17);
                    addPower = rand.Next(4, 9);
                    addLuck = rand.Next(3, 7);
                    addMana = rand.Next(2, 6);
                    break;
                case CombatClass.Archer:
                    addHealth = rand.Next(6, 16);
                    addPower = rand.Next(5, 10);
                    addLuck = rand.Next(2, 5);
                    addMana = rand.Next(3, 7);
                    break;
                case CombatClass.Healer:
                    addHealth = rand.Next(8, 18);
                    addPower = rand.Next(2, 6);
                    addLuck = rand.Next(1, 4);
                    addMana = rand.Next(6, 12);
                    break;
            }


         

        }
        public void CalculateTotals()
        {
            // Implementation for calculating total stats
        }
    }
}

using FinalBattler.Interfaces;

namespace FinalBattler.Character
{

    public abstract class Hero : Creations, IHero
    {

        private int life;
        private int energy;
        private int lucky;
        private int magicM;

        public CombatClass Class { get; protected set; }
                                      
        public int Health => life;
        public int Power => energy;
        public int Luck => lucky;
        public int Mana => magicM;

        public bool IsAlive => life > 0;


        public IAttackBehavior AttackBehavior { get; protected set; }

        protected Hero(string name)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "No one" : name;
            Level = 1;

            life = 100;
            energy = 10;
            lucky = 2;
            magicM = 10;

            CalculateTotals();
        }

        public void DisplayStats(bool showTotalStats = false)
        {
          Console.WriteLine($"[{Name}] Lv {Level} ({Class})");

            Console.WriteLine($"HP: {Health} | Pow: {Power} | Luck: {Luck} | Mana: {Mana}");
            Console.WriteLine($"Attack: {AttackBehavior?.Name ?? "None"}");

            if (showTotalStats)
            {
                Console.WriteLine($"Totals -> HP:{TotalHealth} Pow:{TotalPower} Luck:{TotalLuck}");
            }

            Console.WriteLine();
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0) amount = 0;
            life -= amount;
            if (life < 0) life = 0;
        }

   


        public int Attack(Hero defender)
        {
            if (AttackBehavior == null)
                throw new InvalidOperationException("AttackBehavior  doesnt exit dumb .");

            return AttackBehavior.Attack(this, defender);
        }


        public void LevelUp()
        {
            ApplyLevelUp();
            Level++;
            CalculateTotals();
        }

        protected abstract void ApplyLevelUp();


        protected void AddStats(int health, int power, int luck, int mana)
        {
            life += Math.Max(0, health);
            energy += Math.Max(0, power);
            lucky += Math.Max(0, luck);
            magicM += Math.Max(0, mana);
        }

        public void CalculateTotals()
        {

            TotalHealth = life;
            TotalPower = energy;
            TotalLuck = lucky;
        }
        public void SpendMana(int amount)
        {
            
        }

    }
}
  

    //public sealed class WarriorAtt

//namespace FinalBattler.Character
//{
//    public class Hero : Creations, IHero
//    {
//        private int life;
//        private int energy;
//        private int lucky;
//        private int magicM;

//        public int Health => life;
//        public int Power => energy;
//        public int Luck => lucky;
//        public int Mana => magicM;

//        public int ExperienceRemaining { get; private set; }

//        // Behavior por composición (Strategy)
//        public IAttackBehavior AttackBehavior { get; protected set; }
//        public ILevelUpStrategy LevelUpStrategy { get; protected set; }

//        public bool IsAlive => life > 0;

//        public int Health { get; set; }
//        public int Power { get; set; }
//        public int Luck { get; set; }
//        public int Mana { get; set; }
//        public int ExperienceRemaining { get; set; }
//        public CombatClass CombatClass { get; set; }
//        public List<Item> Items { get; set; }
//        public List<Skill> Skills { get; set; }
//        public List<Spell> Spells { get; set; }
//        public List<Equipment> Equipment { get; set; }

//        public Hero()
//        {
//            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
//            Level = 0;
//           Health = 1;
//           Power = 1;
//           Luck = 1;
//           Mana = 1;
//           ExperienceRemaining = 1;

//        }
//        public void DisplayStats(bool showTotalStats = false)
//        {
//            // Implementation for displaying hero stats
//        }
//        public void LevelUp()
//        {
//            // Implementation for leveling up the hero]
//            Random rand = new Random();

//            int addHealth = 0;
//            int addPower = 0;
//            int addLuck = 0;
//            int addMana = 0;

//            switch(CombatClass)
//            {
//                case CombatClass.Warrior:
//                    addHealth = rand.Next(10, 21);
//                    addPower = rand.Next(5, 11);
//                    addLuck = rand.Next(1, 4);
//                    addMana = rand.Next(0, 3);
//                    break;
//                case CombatClass.Mage:
//                    addHealth = rand.Next(5, 16);
//                    addPower = rand.Next(3, 8);
//                    addLuck = rand.Next(1, 4);
//                    addMana = rand.Next(8, 16);
//                    break;
//                case CombatClass.Rogue:
//                    addHealth = rand.Next(7, 17);
//                    addPower = rand.Next(4, 9);
//                    addLuck = rand.Next(3, 7);
//                    addMana = rand.Next(2, 6);
//                    break;
//                case CombatClass.Archer:
//                    addHealth = rand.Next(6, 16);
//                    addPower = rand.Next(5, 10);
//                    addLuck = rand.Next(2, 5);
//                    addMana = rand.Next(3, 7);
//                    break;
//                case CombatClass.Healer:
//                    addHealth = rand.Next(8, 18);
//                    addPower = rand.Next(2, 6);
//                    addLuck = rand.Next(1, 4);
//                    addMana = rand.Next(6, 12);
//                    break;
//            }




//        }
//        public void CalculateTotals()
//        {
//            // Implementation for calculating total stats
//        }
//    }
//}

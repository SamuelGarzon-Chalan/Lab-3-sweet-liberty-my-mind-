using System;
using FinalBattler.Character;

namespace FinalBattler.Character.Upgrades
{
    public class Spell
    {
        public string SpellName { get; set; }
        public int ManaCost { get; set; }
        public int BaseDamage { get; set; }

        public Spell(string name, int manaCost, int baseDamage)
        {
            SpellName = name;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
        }

       
        
    }
}

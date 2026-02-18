namespace FinalBattler.Character.Upgrades
{
    public class Skill
    {
        public string SkillName { get; set; }
        public int BaseDamage { get; set; }
        public int MaxCooldown { get; private set; }
        public int CurrentCooldown { get; private set; }

        public Skill(string name, int baseDamage, int cooldown)
        {
            SkillName = name;
            BaseDamage = baseDamage;
            MaxCooldown = cooldown;
            CurrentCooldown = 0; 
        }

        public void UseSkill(Hero hero)
        {
        }

        public void CooldownTick()
        {
        }
    }
}

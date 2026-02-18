namespace FinalBattler.Character.Upgrades
{
    public class Equipment
    {
        public string EquipmentName { get; set; } = string.Empty;
        public EquipmentSlot Slot { get; set; }
        public StatBoostType StatBoostType { get; set; }
        public int BoostValue { get; set; }

        public Equipment()
        {
        }

        public Equipment(string name, EquipmentSlot slot, StatBoostType statBoostType, int boostValue)
        {
            
        }
    }
    public enum EquipmentSlot
    {
      
    }

    public enum StatBoostType
    {
     
    }
}

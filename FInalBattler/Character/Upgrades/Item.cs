namespace FinalBattler.Character.Upgrades
{
    public class Item
    {
        public string ItemName { get; set; } 
        public string Description { get; set; }
        public int ItemPower { get; set; }

        public Item()
        {
        }

        public Item(string name, string description)
        {
            ItemName = name;
            Description = description;
        }
    }
}

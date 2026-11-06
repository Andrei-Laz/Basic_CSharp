namespace P1_AdventurerBag
{
    public class Potion: IPickable
    {
        public int HealAmount { get; }

        public string Name => "Potion";
        public float Weight => 4f;
        public string Description => $"Heals {HealAmount} HP";

        public Potion(int healAmount)
        {
            HealAmount = healAmount;
        }
    }
}
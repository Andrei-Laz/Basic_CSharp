namespace P1_AdventurerBag
{
    public class Treasure : IPickable
    {
        public int GoldValue { get; }

        public string Name => "Treasure";
        public float Weight => 10f;
        public string Description => $"Value : {GoldValue}";

        public Treasure(int goldValue)
        {
            GoldValue = goldValue;
        }
    }
}
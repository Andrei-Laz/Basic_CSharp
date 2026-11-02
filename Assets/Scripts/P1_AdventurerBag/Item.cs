namespace P1_AdventurerBag
{
    public class Item
    {
        public string Name { get; }
        public float Weight { get; }

        public Item(string name, float weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
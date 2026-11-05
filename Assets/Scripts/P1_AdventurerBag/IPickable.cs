namespace P1_AdventurerBag
{
    public interface IPickable
    {
        public string Name { get; }
        public float Weight { get; }

        public string Description { get; set; }
        
    }
}
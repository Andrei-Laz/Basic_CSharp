namespace P1_AdventurerBag
{
    public class Sword: IPickable
    {
        public float Damage { get; }
        
        public string Name => "Sword";
        public float Weight => 4f;
        public string Description => $"Damage: {Damage}";
        
        public Sword(float damage)
        {
            Damage = damage;
        }
    }
}
namespace P1_AdventurerBag
{
    public class Key : IPickable, IOnPickup
    {
        public string DoorId { get; }
        
        public string Name => "Key";
        public float Weight => 1f;
        public string Description => $"Opens: {DoorId}";
        
        public Key(string doorId)
        {
            DoorId = doorId;
        }
        
        public void OnPickedUp(Player player)
        {
            player.AddKey(DoorId);
        }
    }
}
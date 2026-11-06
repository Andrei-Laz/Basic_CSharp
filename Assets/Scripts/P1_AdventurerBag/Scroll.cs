namespace P1_AdventurerBag
{
    public class Scroll: IPickable, IOnPickup
    {
        public string Spell { get; }
        
        public string Name => "Scroll";
        public float Weight => 2f;
        public string Description => $"{Name}: {Spell}";
        
        public Scroll (string spell)
        {
            Spell = spell;
        }

        public void OnPickedUp(Player player)
        {
            player.LearnSpell(Spell);
        }
    }
}
using UnityEngine;

namespace P1_AdventurerBag
{
    public class P1AdventurerBagTest : MonoBehaviour
    {
        
        [SerializeField] public BackpackBar backpackBar;
        [SerializeField] private float maxLoad = 100f;
        
        private void Start()
        {

            backpackBar.SetMaxLoad(maxLoad);
            
            Player player1 = new Player("Link", maxLoad, backpackBar);

            Key key1 = new Key("Normal Key");
            
            player1.TryPick(key1);
        }
    }
}
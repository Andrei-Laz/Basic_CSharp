using UnityEngine;

namespace P1_AdventurerBag
{
    public class P1AdventurerBagTest : MonoBehaviour
    {
        
        [SerializeField] public BackpackBar backpackBar;
        private float MaxLoad = 5f;
        
        private void Start() 
        {

            backpackBar.SetMaxLoad(MaxLoad);
            
            Player player1 = new Player("Link", MaxLoad, backpackBar);

            Key key1 = new Key("Normal Key");
            
            player1.TryPick(key1);
        }
    }
}
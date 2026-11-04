using UnityEngine;

namespace P1_AdventurerBag
{
    public class P1AdventurerBagTest : MonoBehaviour
    {
        
        [SerializeField] BackpackBar backpackBar;
        [SerializeField] private float maxLoad = 100f;
        
        private void Start()
        {

            backpackBar.SetMaxLoad(maxLoad);
            Player player1 = new Player("Link", maxLoad, backpackBar);

            Item sword = new Item("Sword", 20);
            Item spear = new Item("Spear", 25);
            Item greatsword = new Item("Greatsword", 30);
            Item bow = new Item("Bow", 20);
            Item staff = new Item("Staff", 25);
            Item shield = new Item("Shield", 30);
            Item potion = new Item("Potion", 10);
            Item meat = new Item("Meat", 10);
            Item waterPouch = new Item("WaterPouch", 10);
            Item coin = new Item("Coin", 2);

            player1.Tryadd(sword);
            player1.Tryadd(sword);
            Debug.Log(player1.IsOverload); 
        }
    }
}
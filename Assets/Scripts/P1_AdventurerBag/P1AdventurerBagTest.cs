using UnityEngine;

namespace P1_AdventurerBag
{
    public class P1AdventurerBagTest : MonoBehaviour
    {
        private void Start()
        {

            Player player1 = new Player("Link", 100);

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
            player1.Tryadd(greatsword);
            player1.Tryadd(potion);
            player1.Tryadd(bow);
            player1.Tryadd(staff);
            player1.CanAdd(shield);
            player1.CanAdd(potion);
            player1.Tryadd(potion);
            player1.Listbackpack();
            player1.TryRemove("Bow");
            player1.Listbackpack();
            player1.Tryadd(staff);
            player1.TryRemove("Sword");
            player1.Listbackpack();
        }
    }
}
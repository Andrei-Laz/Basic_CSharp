using UnityEngine;

namespace Ex_8
{
    public class GenericTest: MonoBehaviour
    {
        static void Main()
        {
            GenericSinglyLinkedList<int> lista1 = new GenericSinglyLinkedList<int>();
            GenericSinglyLinkedList<string> lista2 = new GenericSinglyLinkedList<string>();
            GenericSinglyLinkedList<Enemy> lista3 = new GenericSinglyLinkedList<Enemy>();
            
            //Debug.Log("Hi");

            lista1.InsertAtBeginning(3);
            lista1.InsertAtBeginning(12);
            lista1.InsertAtBeginning(2);
            lista1.InsertAtEnd(5);
            lista1.InsertAtBeginning(6);
            lista1.InsertAtEnd(11);
            lista1.InsertAtEnd(2);
            lista1.ToDisplayString();
            
            lista2.InsertAtBeginning("Hola");
            lista2.ToDisplayString();
            
            Enemy elf = new Enemy();
            
            lista3.InsertAtBeginning(elf);
            lista3.ToDisplayString();
        }

        void Start()
        {
            Main();
        }
    }
}
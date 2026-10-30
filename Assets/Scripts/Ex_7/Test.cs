using System;
using UnityEngine;

namespace Ex_7
{
    public class Test : MonoBehaviour
    {
        static void Main()
        {
            SinglyLinkedList lista1 = new SinglyLinkedList();
            SinglyLinkedList lista2 = new SinglyLinkedList();

            //Debug.Log("Hi");

            lista1.InsertAtBeginning(3);
            lista1.InsertAtBeginning(12);
            lista1.InsertAtBeginning(2);
            lista1.InsertAtEnd(5);
            lista1.InsertAtBeginning(6);
            lista1.InsertAtEnd(11);
            lista1.InsertAtEnd(2);
            lista1.Remove(2);
            lista1.ToDisplayString();
            
            lista2.ToDisplayString();
        }

        void Start()
        {
            Main();
        }
    }
}
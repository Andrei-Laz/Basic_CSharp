using System;
using UnityEngine;

namespace Ex_7
{
    public class Test : MonoBehaviour
    {
        static void Main()
        {
            Debug.Log(0<0);

            SinglyLinkedList lista1 = new SinglyLinkedList();
            SinglyLinkedList lista2 = new SinglyLinkedList();

            lista1.InsertAtBeginning(3);
            lista1.InsertAtBeginning(12);
            lista1.InsertAtBeginning(2);
            lista1.InsertAtEnd(5);
            lista1.InsertAtBeginning(6);
            lista1.InsertAtEnd(11);
            lista1.InsertAtEnd(2);
            lista1.Remove(2);
            lista1.ToDisplayString();

            lista1.RemoveAt(2);
            lista1.ToDisplayString();

            lista1.InsertAt(0, 69);
            lista1.InsertAt(2, 99);
            lista1.ToDisplayString();

            Debug.Log("size: " + lista1.Size());

            lista1.InsertAt(6, 25);
            lista1.ToDisplayString();

            Debug.Log(lista1.Contains(5));
            Debug.Log(lista1.Contains(100));

            lista1.Reverse();
            lista1.ToDisplayString();
            Debug.Log("size: " + lista1.Size());

            lista2.ToDisplayString();
            lista2.InsertAtBeginning(2);
            lista2.InsertAtBeginning(3);
            lista2.InsertAtBeginning(4);
            lista2.RemoveAt(5);
            lista2.ToDisplayString();
        }

        void Start()
        {
            Main();
        }
    }
}
using System;
using UnityEngine;

namespace Ex_7
{
    public class Test : MonoBehaviour
    {
        static void Main()
        {
            SinglyLinkedList lista1 = new SinglyLinkedList();
            
            lista1.InsertAtBeginning(12);
            lista1.ToDisplayString();
        }

        void Start()
        {
            Main();
        }
    }
}
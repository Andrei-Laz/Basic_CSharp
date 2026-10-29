using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace Ex_7
{
    public class SinglyLinkedList
    {
        [CanBeNull] private Node _head;
        private int _count;

        public void InsertAtBeginning (int value)
        {
            Node toAdd = new Node();
            toAdd.Value = value;
            toAdd.Next = _head;
            _head = toAdd;
            
            _count++;
        }

        public void InsertAtEnd(int value)
        {
            Node toAdd = new Node();
            toAdd.Value = value;

            if (_head != null)
            {
                Node current = _head;
                current.Next = toAdd;
            }
            else
            {
                _head = toAdd;
            }
            _count++;
        }
        
        public void ToDisplayString()
        {
            Node current = _head;
            while (current != null) 
            {
                Debug.Log(current.Value);
                current = current.Next;
            }
            
        }
    }
}
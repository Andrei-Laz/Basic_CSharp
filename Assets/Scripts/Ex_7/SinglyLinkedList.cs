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
            if (_head != null)
            {
                Node toAdd = new Node();
                toAdd.Value = value;
                
                Node current = _head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
            else
            {
                _head = new Node();
                _head.Value = value;
                _head.Next = null;
            }
            _count++;
        }

        public void Remove(int value)
        {
            Node current = _head;

            if (current != null)
            {
                while (current.Value != value)
                {
                    current = current.Next;
                }

                //current.Value = current.Next.Value;
                do
                {
                    current.Value = current.Next.Value;
                } while (current.Next != null);

                _count--;
            }
            else
            {
                Debug.Log("List is empty. Cannot remove Anything");
            }
        }
        
        public void ToDisplayString()
        {
            Node current = _head;
            string list = "";
            
            if (_head != null)
            {
                while (current != null)
                {
                    if (current.Next != null)
                    {
                        list = list + current.Value + " -> ";
                    }
                    else
                    {
                        list = list + current.Value;
                    }
                    current = current.Next;
                }

            }
            else
            {
                list = "∅";
            }

            Debug.Log(list);
        }
    }   
}
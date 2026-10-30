using Ex_7;
using JetBrains.Annotations;
using UnityEngine;

namespace Ex_8  
{
    public class GenericSinglyLinkedList<T>
    {
        [CanBeNull] private GenericNode<T> _head;
        private int _count;

        public void InsertAtBeginning (T value)
        {
            GenericNode<T> toAdd = new GenericNode<T>();
            toAdd.Value = value;
            toAdd.Next = _head;
            _head = toAdd;
            
            _count++;
        }

        public void InsertAtEnd(T value)
        {
            if (_head != null)
            {
                GenericNode<T> toAdd = new GenericNode<T>();
                toAdd.Value = value;
                
                GenericNode<T> current = _head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
            else
            {
                _head = new GenericNode<T>();
                _head.Value = value;
                _head.Next = null;
            }
            _count++;
        }

        // public void Remove(T value)
        // {
        //     GenericNode<T> current = _head;
        //
        //     if (current != null)
        //     {
        //         while (current.Value != value)
        //         {
        //             current = current.Next;
        //         }
        //
        //         //current.Value = current.Next.Value;
        //         do
        //         {
        //             current.Value = current.Next.Value;
        //         } while (current.Next != null);
        //
        //         _count--;
        //     }
        //     else
        //     {
        //         Debug.Log("List is empty. Cannot remove Anything");
        //     }
        // }
        
        public void ToDisplayString()
        {
            GenericNode<T> current = _head;
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
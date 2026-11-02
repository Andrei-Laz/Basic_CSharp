using System.Collections.Generic;
using UnityEngine;

namespace P1_AdventurerBag
{
    public class Player
    {
        public string Name { get; }
        public float MaxLoad { get; }
        private readonly List<Item> _backpack = new List<Item>();

        public Player(string name, float maxLoad)
        {
            Name = name;
            MaxLoad = maxLoad;
        }
        
        public float CurrentLoad
        {
            get
            {
                float value = 0;
                try
                {
                    foreach (var item in _backpack)
                    {
                        value += item.Weight;
                    }

                    return value;
                }
                catch (System.Exception)
                {
                    return value;
                }
            }
        }

        public bool CanAdd(Item item)
        {
            if (item.Weight + CurrentLoad > MaxLoad)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Tryadd(Item item)
        {
            float exceededWeight;
            
            if (CanAdd(item))
            {
                _backpack.Add(item);
                Debug.Log($"Item {item.Name} added");
                //return true;
            }
            else
            {
                exceededWeight = item.Weight + CurrentLoad - MaxLoad;
                Debug.LogWarning($"Item {item.Name} not added because it exceeded maximum load by {exceededWeight}");
                //return false;
            }
        }

        public void Listbackpack()
        {
            foreach (var item in _backpack)
            {
                Debug.Log(item);
            }
        }
        
        bool TryRemove(string name)
        {
            return true;
        }
    }
}
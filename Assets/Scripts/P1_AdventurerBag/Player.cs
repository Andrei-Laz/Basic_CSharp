using System.Collections.Generic;
using UnityEngine;

namespace P1_AdventurerBag
{
    public class Player
    {
        public string Name { get; }
        public float MaxLoad { get; }
        
        public BackpackBar BackpackBar { get; set; }

        public bool IsOverload
        {
            get
            {
                if (CurrentLoad > MaxLoad + 0.5 * MaxLoad)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private readonly List<Item> _backpack = new List<Item>();

        public Player(string name, float maxLoad, BackpackBar backpackBar)
        {
            this.Name = name;
            this.MaxLoad = maxLoad;
            this.BackpackBar = backpackBar;
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
            if (item.Weight + CurrentLoad > MaxLoad + 0.5 * MaxLoad)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Tryadd(Item item)
        {
            if (CanAdd(item))
            {
                _backpack.Add(item);
                Debug.Log($"Item {item.Name} added");
                BackpackBar.SetLoad(CurrentLoad);
                return true;
            }
            else
            {
                var exceededWeight = item.Weight + CurrentLoad - MaxLoad + 0.5f * MaxLoad;
                Debug.LogWarning($"Item {item.Name} not added because it exceeded maximum load by {exceededWeight}");
                return false;
            }
        }

        public void Listbackpack()
        {
            foreach (var item in _backpack)
            {
                Debug.Log(item.Name);
            }
        }

        public bool TryRemove(string name)
        {
            foreach (var item in _backpack)
            {
                if (item.Name == name)
                {
                    _backpack.Remove(item);
                    BackpackBar.SetLoad(CurrentLoad);
                    return true;
                }
            }
            return false;
        }
    }
}
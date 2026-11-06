using System;
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
        
        public float CurrentLoad
        {   
            get
            {
                float value = 0;
                try
                {
                    foreach (var pickable in _backpack)
                    {
                        value += pickable.Weight;
                    }
                    return value;
                }
                catch (System.Exception)
                {
                    return value;
                }
            }
        }

        private readonly List<IPickable> _backpack = new List<IPickable>();
        
        private readonly List<String> _keys = new List<String>();
        private readonly List<String> _spells = new List<string>();

        public Player(string name, float maxLoad, BackpackBar backpackBar)
        {
            this.Name = name;
            this.MaxLoad = maxLoad;
            this.BackpackBar = backpackBar;
        }

        public void AddKey(string id)
        {
            _keys.Add(id);
        }

        public void LearnSpell(string spell)
        {
            _spells.Add(spell);
        }

        public bool HasKey(string id)
        {
            return _keys.Contains(id);
        }

        public bool CanPick(IPickable pickableItem)
        {
            if (pickableItem.Weight + CurrentLoad > MaxLoad + 0.5 * MaxLoad)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TryPick(IPickable pickableItem)
        {
            if (CanPick(pickableItem))
            {
                _backpack.Add(pickableItem);
                Debug.Log($"Item {pickableItem.Name} added");
                BackpackBar.SetLoad(CurrentLoad);
                return true;
            }
            else
            {
                var exceededWeight = pickableItem.Weight + CurrentLoad - MaxLoad + 0.5f * MaxLoad;
                Debug.LogWarning($"Item {pickableItem.Name} not added because it exceeded maximum load by {exceededWeight}");
                return false;
            }
        }

        public void Listbackpack()
        {
            foreach (var pickable in _backpack)
            {
                Debug.Log(pickable.Name);
            }
        }

        public bool TryRemove(string name)
        {
            foreach (var pickable in _backpack)
            {
                if (pickable.Name == name)
                {
                    _backpack.Remove(pickable);
                    BackpackBar.SetLoad(CurrentLoad);
                    return true;
                }
            }
            return false;
        }
    }
}
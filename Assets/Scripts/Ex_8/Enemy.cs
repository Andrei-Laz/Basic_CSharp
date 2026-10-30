using UnityEngine;

namespace Ex_8
{
    public class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public string Attack()
        {
            return "I attack";
        }
    }
}
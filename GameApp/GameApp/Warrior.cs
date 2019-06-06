using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    class Warrior
    {
        Random rand = new Random();

        private string name;
        private int health;
        private int attackMax;
        private int blockMax;
        private int maxHealth;

        public Warrior(string name, int health, int attackMax, int blockMax)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }
        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }
        public int BlockMax
        {
            get { return blockMax; }
            set { blockMax = value; }
        }

        public int AttackMax
        {
            get { return attackMax; }
            set { attackMax = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Attack()
        {
            return rand.Next(1, attackMax + 1);
        }

        public int Block()
        {
            return rand.Next(1, blockMax + 1);
        }

    }
}

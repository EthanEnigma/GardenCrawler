using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCrawler_Core
{
    public class Entity
    {
        private string _name;
        private int _currentLevel;
        private float _baseHealth;
        private float _maxHealth;
        private float _health;
        private float _armor; // TODO create armor objects
        private float _strength;
        private float _intelligence;
        //private float _accuracy; // TODO

        public Entity(string name, int level) // TODO
        {
            _name = name;
            _currentLevel = level;
            try
            {
                RefreshMaxHealth();
                RefreshStrength();
                RefreshIntelligence();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            _health = _maxHealth;
        }

        public void RefreshBaseHealth() // 20+(level-1)*5
        {
            _baseHealth = 20 + (_currentLevel-1) * 5;
        }
        public void RefreshMaxHealth() // Base + armor + boosts
        {
            _maxHealth = _baseHealth + _armor;
        }

        public void RefreshStrength() // 5+(level-1)*2
        {
            _strength = 5 + (_currentLevel-1) * 2;
        }

        public void RefreshIntelligence() // 5+(level-1)*2
        {
            _intelligence = 5 + (_currentLevel-1) * 2;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int CurrentLevel
        {
            get
            {
                return _currentLevel;
            }
        }
        public float MaxHealth
        {
            get
            {
                return _maxHealth;
            }
        }
        public float Health
        {
            get
            {
                return _health;
            }
        }
        public float Armor
        {
            get
            {
                return _armor;
            }
        }
        public float Strength
        {
            get
            {
                return _strength;
            }
        }
        public float Intelligence
        {
            get
            {
                return _intelligence;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCrawler_Core
{
    public class Entity
    {
        private string _name;
        private int _currentLevel;
        private float _maxHealth;
        private float _health;
        private float _armor;
        private float _strength;
        private float _intelligence;
        private float _accuracy;

        public Entity(string name, int level)
        {
            _name = name;
            _currentLevel = level;


        }
    }
}

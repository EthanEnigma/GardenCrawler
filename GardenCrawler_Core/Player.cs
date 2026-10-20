using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCrawler_Core
{
    public class Player : Entity
    {
        private int _currentXp;
        private int _nextLevelXp;
        private Tuple<uint, uint> _position;
        private List<Item>? _inventoryList;

        public Player(string name, int currentLevel, int currentXp, Tuple<uint,uint> position, List<Item> inventoryList) : base(name, currentLevel)
        {
            _currentXp = currentXp;
            _position = position;
            _inventoryList = inventoryList;

            RefreshNextLevelXp(currentLevel);
        }
        public Player(string name, int currentLevel, int currentXp, Tuple<uint, uint> position) : base(name, currentLevel)
        {
            _currentXp = currentXp;
            _position = position;
            _inventoryList = null;

            RefreshNextLevelXp(currentLevel);
        }

        public void RefreshNextLevelXp(int currentLevel)
        {
            _nextLevelXp = 10 + (currentLevel) * 10;
        }

        public int CurrentXp
        {
            get
            {
                return _currentXp;
            }
        }
        public int NextLevelXp
        {
            get
            {
                return _nextLevelXp;
            }
        }
        public Tuple<uint,uint> Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        public List<Item> Inventory
        {
            get
            {
                return _inventoryList;
            }
        }
    }
}
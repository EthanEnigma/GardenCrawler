using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCrawler_Core
{
    public class Item
    {
        private string _name;
        private string _description;
        private float _price;

        public Item(string name, string description, float price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
        }
        public float Price
        {
            get
            {
                return _price;
            }
        }
    }
}
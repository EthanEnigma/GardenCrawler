using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCrawler_Core
{
    public class TileType // TODO add color to class var + constructor
    {
        private string _id;
        private int _weight;
        private char _character;

        public TileType(string id, int weight, char character)
        {
            _id = id;
            _weight = weight;
            _character = character;
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }
        public int Weight
        {
            get
            {
                return _weight;
            }
        }
        public char Character
        {
            get
            {
                return _character;
            }
        }
    }
}

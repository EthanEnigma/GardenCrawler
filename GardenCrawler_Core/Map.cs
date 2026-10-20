using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace GardenCrawler_Core
{
    public class Map
    {
        private Tuple<uint, uint> _size;
        private int _seed;
            private List<TileType> _tileTypeList = new List<TileType>
            {
                new TileType("Plain", 100, '_'),
                new TileType("TallGrass", 100, '"'),
                new TileType("Bramble", 25, '#'),
                new TileType("Water", 35, '~'),
                new TileType("Village", 15, 'V'),
                new TileType("Dungeon", 10, 'D')
            };
        private Tile[,] _tileArr;
        private Tuple<uint, uint> _playerPos; // TODO

        public Map(Tuple<uint, uint> size)
        {
            _size = size;
            _seed = new Random().Next();
            _tileArr = new Tile[_size.Item1, _size.Item2];
            _playerPos = new Tuple<uint, uint>(1,1);

            GenerateTiles();
        }
        public Map(Tuple<uint, uint> size, int seed)
        {
            _size = size;
            _seed = seed;
            _tileArr = new Tile[_size.Item1, _size.Item2];
            _playerPos = new Tuple<uint, uint>(1,1);

            GenerateTiles();
        }

        // Calculate the type from weights
        public TileType CalculateWeight(Random rnd)
        {
            int totalWeight = 0;

            float currentWeightSum = 0;
            foreach (TileType type in _tileTypeList)
            {
                totalWeight += type.Weight;
            }

            int roll = rnd.Next(totalWeight);

            foreach (TileType type in _tileTypeList)
            {
                currentWeightSum += type.Weight;

                if (roll <= currentWeightSum)
                {
                    return type;
                }
            }
            return null;
        }

        public void DisplayChances() // DEBUG
        {
            int totalWeight = 0;
            foreach (TileType type in _tileTypeList)
            {
                totalWeight += type.Weight;
            }

            foreach (TileType type in _tileTypeList)
            {
                float rarity = (float)type.Weight / totalWeight;
                float rarityPercent = rarity * 100;
                Console.WriteLine("{0} '{1}' [{2}] - {3}%", type.Id, type.Character, type.Weight, Math.Round(rarityPercent, 1));
            }
        }

        // Create and store all map tiles in tileArr
        private void GenerateTiles()
        {
            Random rnd = new Random(_seed);

            for (int i = 0; i < _size.Item1; i++)
            {
                for (int j = 0; j < _size.Item2; j++)
                {
                    Tile newTile = new Tile(CalculateWeight(rnd));
                    _tileArr[i, j] = newTile;
                }
            }
        }

        // Displays the map by looping on all the tiles
        public void DisplayMap() // TODO make more stylized
        {
            for (int i = 0; i < _size.Item2; i++)
            {
                for (int j = 0; j < _size.Item1; j++)
                {
                    Console.Write("{0} ", _tileArr[j,i].Character);
                }
                Console.Write("\n");
            }
        }

        public Tuple<uint, uint> Size
        {
            get
            {
                return _size;
            }
        }

        public int Seed
        {
            get
            {
                return _seed;
            }
        }
    }
}
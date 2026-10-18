using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace GardenCrawler_Core
{
    // Vector2 with int value for the _size
    public struct Vector2Int
    {
        public int _x;
        public int _y;

        public Vector2Int(int xy)
        {
            _x = xy;
            _y = xy;

        }
        public Vector2Int(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }
    }

    public class Map
    {
        private Vector2Int _size;
        private int _seed;
        private Tile[,] _tileArr;
        private Vector2Int _playerPos; // TODO

        public Map(Vector2Int size)
        {
            _size = size;
            _seed = new Random().Next();
            _tileArr = new Tile[_size.X, _size.Y];

            GenerateTiles();
        }
        public Map(Vector2Int size, int seed)
        {
            _size = size;
            _seed = seed;
            _tileArr = new Tile[_size.X, _size.Y];

            GenerateTiles();
        }

        // Create and store all map tiles in tileArr
        private void GenerateTiles()
        {
            Random rnd = new Random(_seed);
            Array tileTypeArr = Enum.GetValues(typeof(TileType)); // Study

            for (int i = 0; i < _size.X; i++)
            {
                for (int j = 0; j < _size.Y; j++)
                {
                    try
                    {
                        TileType rndTile = (TileType)tileTypeArr.GetValue(rnd.Next(tileTypeArr.Length));
                        _tileArr[i, j] = new Tile(rndTile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        // Displays the map by looping on all the tiles
        public void DisplayMap()
        {
            for (int i = 0; i < _size.Y; i++)
            {
                for (int j = 0; j < _size.X; j++)
                {
                    Console.Write("{0} ", _tileArr[j, i].Letter);
                }
                Console.Write("\n");
            }
        }

        public Vector2Int Size
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
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace GardenCrawler_Core
{
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

    internal class Map
    {
        private Vector2Int _size;
        private int _seed;
        private Tile[,] _tileArr;

        public Map(Vector2Int size, int seed) // TODO
        {
            _size = size;
            _seed = seed;
        }
        public Map(Vector2Int size) // TODO
        {
            _size = size;
            Random rnd = new Random();
            _seed = rnd.Next();

            _tileArr = new Tile[1,1];

            for (int i = 0; i < _size.X; i++)
            {
                for (int j = 0; j < _size.Y; j++)
                {
                    AddTile();
                }
            }
        }

        private void AddTile()
        {
            Array TileTypeArr = Enum.GetValues(typeof(TileType));
            Random rnd = new Random();
            TileType randomTile = (TileType)TileTypeArr.GetValue(rnd.Next(TileTypeArr.Length));

            Tile newTile = new Tile(randomTile);

        }

        public void PrintTiles() // DEBUG
        {
        }

        public Vector2Int Size
        {
            get
            {
                return _size;
            }
        }
    }
}

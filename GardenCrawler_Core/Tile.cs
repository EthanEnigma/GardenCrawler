using System.Formats.Tar;
using System.Runtime.InteropServices;

namespace GardenCrawler_Core
{
    internal class Tile // TODO implement weights for each tileType for rarities
    {
        private TileType _type;
        private char _character;
        private int _weight;

        public Tile(TileType type)
        {
            _type = type;
            _character = _type.Character;
        }
        public TileType Type
        {
            get
            {
                return _type;
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
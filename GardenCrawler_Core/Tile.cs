namespace GardenCrawler_Core
{
    public enum TileType
    {
        Plain,
        TallGrass,
        Brambles,
        Water,
        Village,
        Dungeon
    };

    internal class Tile // TODO implement zeights for each tileType for rarities
    {
        private TileType _type;
        private char _letter;

        public Tile(TileType type)
        {
            _type = type;

            switch (_type)
            {
                case TileType.Plain:
                    _letter = '.';
                    break;
                case TileType.TallGrass:
                    _letter = '"';
                    break;
                case TileType.Brambles:
                    _letter = '#';
                    break;
                case TileType.Water:
                    _letter = '~';
                    break;
                case TileType.Village:
                    _letter = 'V';
                    break;
                case TileType.Dungeon:
                    _letter = 'D';
                    break;
            }
        }

        public TileType Type
        {
            get
            {
                return _type;
            }
        }

        public char Letter
        {
            get
            {
                return _letter;
            }
        }
    }
}

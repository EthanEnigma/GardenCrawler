using System.Numerics;
using GardenCrawler_Core;

namespace GardenCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new Vector2Int(5,5));
            map.DisplayMap();
        }
    }
}
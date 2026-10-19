using System.Numerics;
using GardenCrawler_Core;

namespace GardenCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new Tuple<int, int>(10,10), 5);

            map.DisplayMap();
            Console.Write("\n");
            map.DisplayChances();
            
            Entity mob1 = new Entity("MyMob",1);
            Console.Write("\n");
            Console.Write("{0} - LVL {1} - HP {2}/{3} - ARM {4} - STR {5} - INT {6}", mob1.Name, mob1.CurrentLevel, mob1.Health, mob1.MaxHealth, mob1.Armor, mob1.Strength, mob1.Intelligence);
        }
    }
}
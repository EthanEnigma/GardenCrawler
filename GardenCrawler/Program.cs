using System.Numerics;
using GardenCrawler_Core;

namespace GardenCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new Tuple<uint, uint>(10,10),156154);

            map.DisplayMap();
            Console.Write("\n");
            map.DisplayChances();
            
            Entity mob1 = new Entity("MyMob",1);
            Console.Write("\n");
            Console.Write("{0} - LVL {1} - HP {2}/{3} - ARM {4} - STR {5} - INT {6}", mob1.Name, mob1.CurrentLevel, mob1.Health, mob1.MaxHealth, mob1.Armor, mob1.Strength, mob1.Intelligence);

            Player plr1 = new Player("myPlayer", 3, 0, new Tuple<uint, uint>(1,1));
            Console.Write("\n");
            Console.Write($"{plr1.Name} - LVL {plr1.CurrentLevel} - XP {plr1.CurrentXp}/{plr1.NextLevelXp} - HP {plr1.Health}/{plr1.MaxHealth} - ARM {plr1.Armor} - STR {plr1.Strength} - INT {plr1.Intelligence} - INV {plr1.Inventory} - X {plr1.Position.Item1} Y {plr1.Position.Item2}");
            Console.Write("\n");
        }
    }
}
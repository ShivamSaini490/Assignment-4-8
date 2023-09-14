using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    static void Main()
    {
        Season currentSeason = Season.Summer;

        switch (currentSeason)
        {
            case Season.Spring:
                Console.WriteLine("It's Spring! Flowers are blooming.");
                break;
            case Season.Summer:
                Console.WriteLine("It's Summer! Enjoy the warm weather.");
                break;
            case Season.Autumn:
                Console.WriteLine("It's Autumn! Leaves are falling.");
                break;
            case Season.Winter:
                Console.WriteLine("It's Winter! Bundle up and stay warm.");
                break;
            default:
                Console.WriteLine("Invalid season.");
                break;
        }

        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Three
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage espressor = new Expresso();
            Console.WriteLine(espressor.getDescription() + " $ " + espressor.cost());

            Beverage beverage2 = new DarkRoast();
            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost());
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost());

            Beverage beverage3 = new HouseBlend();

            beverage3 = new Mocha(beverage3);
            beverage3 = new Soy(beverage3);
            beverage3 = new Whip(beverage3);

            Console.WriteLine(beverage3.getDescription() + " $ " + beverage3.cost());

            Console.ReadKey();
        }
    }
}

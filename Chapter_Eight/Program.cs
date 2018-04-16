using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCoffee nCoffee = new NewCoffee();
            nCoffee.prepareRecipe();

            Console.ReadKey();
        }
    }
}

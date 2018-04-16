using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Eight
{
    public class NewCoffee:CoffeineBeverage
    {

        public override void brew()
        {
            Console.WriteLine("brew Coffee");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Add condiments in coffee");
        }
    }
}

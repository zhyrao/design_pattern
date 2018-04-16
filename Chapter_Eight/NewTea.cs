using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Eight
{
    public class NewTea:CoffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Brew the tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Add condiments in tea");
        }
    }
}

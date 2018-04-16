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

        public override bool customerWantsCondiments()
        {
            Console.WriteLine("Would u like some tea or milk in you Coffee?\n");

            string readin = Console.ReadLine();

            if (readin.ToLower().Contains("y"))
                return true;

            return false;
        }
    }
}

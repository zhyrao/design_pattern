using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Four
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza pizza = nyPizzaStore.orderPizza("cheese");
            pizza.Display();

            Console.ReadKey();
        }
    }
}

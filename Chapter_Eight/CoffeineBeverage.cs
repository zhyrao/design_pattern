using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Eight
{
    public abstract class CoffeineBeverage
    {

        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("boiling the water");
        }

        public void pourInCup()
        {
            Console.WriteLine("pouring in the cup");
        }
    }
}

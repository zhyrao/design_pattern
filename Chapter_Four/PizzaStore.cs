using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Four
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(string type);
    }


    public class NYPizzaStore :PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();
            else if (type.Equals("Veiggie"))
                return new NYStyleVeiggiePizza();
            else if (type.Equals("clam"))
                return new NYStyleClamPizza();
            else
                return null;
        }
    }
}

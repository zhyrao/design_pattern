using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Four
{
    public interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        Veggies[] createVeggies();
        Pepperoni createPepperoni();
        Clam createClam();
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            throw new NotImplementedException();
        }

        public Clam createClam()
        {
            throw new NotImplementedException();
        }

        public Dough createDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni createPepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce createSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] createVeggies()
        {
            throw new NotImplementedException();
        }
    }
}

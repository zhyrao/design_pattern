using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Four
{
    // 抽象披萨类，所有具体披萨都必须派生之这个类
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        List<string> toppings = new List<string>();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza in to diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Putting pizza in a offical box");
        }

        public void prepare()
        {
            Console.WriteLine("Prepare for pizza");
        }

        public string getName()
        {
            return name;
        }

        public void Display()
        {
            Console.WriteLine("Pizza Name: " + name + "\nPizza Dough: " + dough + "\nPizza Sauce: " + sauce);
        }
    }


    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            this.name = "NYStyleCheesePize";
            this.dough = "Thin";
            this.sauce = "Light";
        }
    }

    public class NYStyleVeiggiePizza : Pizza
    {
        public NYStyleVeiggiePizza()
        {
            this.name = "NYStyleVeiggiePizza";
            this.dough = "Thin";
            this.sauce = "Light";
        }
    }


    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            this.name = "NYStyleClamPizza";
            this.dough = "Thin";
            this.sauce = "Light";
        }
    }
}

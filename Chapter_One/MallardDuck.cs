using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_One
{
    public class MallardDuck:Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck!");
        }
    }

    public class ModelDuck:Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a wood duck");
        }
    }
}

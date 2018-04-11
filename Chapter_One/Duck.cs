using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_One
{
    public abstract class Duck
    {
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;

        public Duck() { }

        public void performFly()
        {
            flyBehaviour.fly();
        }

        public void performQuack()
        {
            quackBehaviour.quack();
        }

        // 实现动态更变行为
        public void SetFlyMethod(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        // 动态改变叫声
        public void SetQuackMethod(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

        public abstract void Display();

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_One
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.performFly();
            mallardDuck.performQuack();

            // 动态改变飞行方式
            ModelDuck modeDuck = new ModelDuck();
            modeDuck.performFly();
            modeDuck.SetFlyMethod(new FlyWithRocket());
            modeDuck.performFly();

            Console.ReadKey();
        }
    }
}

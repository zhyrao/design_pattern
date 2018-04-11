using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_One
{
    // 飞行行为接口
    public interface FlyBehaviour
    {
        void fly();
    }


    // 不会飞行类
    public class FlyNoWay : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm not fly");
        }
    }

    // 用翅膀飞行类
    class FlyWithWings : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm fly with wings!");
        }
    }

    // 用火箭飞行
    class FlyWithRocket:FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm fly with rocket power");
        }
    }
}

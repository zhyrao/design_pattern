using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_One
{
    // 呱呱叫接口
    public interface QuackBehaviour
    {
        void quack();
    }


    // 呱呱叫类
    class Quack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    // 不会叫
    class MuteQuack:QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<<silence>>");
        }
    }

    // 吱吱叫
    class Squeak: QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}

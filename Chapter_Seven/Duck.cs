using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Seven
{
    public interface Duck
    {
        void quack();
        void fly();
    }

    public class MallardDuck:Duck
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }

        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

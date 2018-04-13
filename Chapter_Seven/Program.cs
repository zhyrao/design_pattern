using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Seven
{
    class Program
    {
        static void Main(string[] args)
        {

            MallardDuck mallardDuck = new MallardDuck();
            WildTurkey wildTurkey = new WildTurkey();

            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(wildTurkey);

            wildTurkey.gobble();
            wildTurkey.fly();

            TestDuck(mallardDuck);
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}

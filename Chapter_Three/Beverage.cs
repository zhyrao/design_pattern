using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Three
{
    // 原始设计的Beverage类 抽象类
    public abstract class Beverage
    {
        public string description = "Unkown Beverage";

        // 已经实现
        public string getDescription()
        {
            return description;
        }

        // 必须在子类实现
        public abstract double cost();
    }

    // 装饰者类
    // 首先要继承Beverage类，使得有同样的类型
    public abstract class CondimentDecorator: Beverage
    {
        public abstract new string getDescription();
    }


    // 组件类
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    // 组件类
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.99;
        }
    }

    // 组件类
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double cost()
        {
            return 1.59;
        }
    }

    // 组件类
    public class Decat:Beverage
    {
        public Decat()
        {
            description = "Decat Coffee";
        }

        public override double cost()
        {
            return 1.79;
        }
    }

    // 装饰者类
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage b)
        {
            this.beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }

    public class Soy :CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage b)
        {
            this.beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }

    public class Whip:CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage b)
        {
            this.beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.25 + beverage.cost();
        }
    }
}

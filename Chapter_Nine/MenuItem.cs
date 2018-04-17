using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Nine
{
    // 菜单项目类
    // 包括了名称，描述，是否素食，价格等。
    public class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string desc, bool vege, double price)
        {
            this.name = name;
            this.description = desc;
            this.vegetarian = vege;
            this.price = price;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public bool isVegetarian()
        {
            return this.vegetarian;
        }

        public double getPrice()
        {
            return this.price;
        }
    }
}

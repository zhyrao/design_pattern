using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Nine
{
    public class PancakeHouseMenu
    {
        ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            addItems("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            addItems("Regular Pancake Breakfast",
                "Pancakes with fried eggs, and sausage",
                false,
                2.99);

            addItems("Blueburry Pancake",
               "Pancakes made with fresh blueburries",
               true,
               3.49);

            addItems("Waffles",
               "Waffles with your choice of blueburries or strawburries",
               true,
               3.59);
        }

        public void addItems(string name, string desc, bool isVege, double price)
        {
            MenuItem menuItem = new MenuItem(name, desc, isVege, price);

            menuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }

        public ArrayList getMenuItems()
        {
            return menuItems;
        }

        /*
         * 其他方法
         *
         */

    }
}

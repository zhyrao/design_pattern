using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Nine
{
    public class DinerMenu:Menu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            addItems("Vegetarian BLT",
                "(Faking)Bacon with lettuce & tomato on whole wheat", true, 2.99);

            addItems("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99);

            addItems("Soup of the Day",
                "Soup of the Day, with sliced salad", false, 3.29);

            addItems("HotDog",
                "HotDog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void addItems(string name, string desc, bool isVege, double price)
        {
            MenuItem menuItem = new MenuItem(name, desc, isVege, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("sorry, menu is full! can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }
    }
}

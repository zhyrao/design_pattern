using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Nine
{
    public class Waitress
    {
        PancakeHouseMenu pancakeMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeMenu, DinerMenu dinerMenu)
        {
            this.pancakeMenu = pancakeMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            Iterator pancakeIterator = pancakeMenu.createIterator();        
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("MENU\n ---------- \nBreakFast");
            PrintMenu(pancakeIterator);
            Console.WriteLine(" ---------- \nLaunch");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while(iterator.hasNext())
            {
                MenuItem item = (MenuItem)iterator.next();
                Console.WriteLine(item.getName() + ", " + item.getPrice() + " -- " + item.getDescription());
            }
        }
    }
}

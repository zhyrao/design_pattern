using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Nine
{
    public interface Iterator
    {
        Object next();

        bool hasNext();
    }


    public class DinerMenuIterator:Iterator
    {
        MenuItem[] menuItems;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.menuItems = items;
        }

        public Object next()
        {
            MenuItem menuItem = menuItems[position];
            position = position + 1;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= menuItems.Length || menuItems[position] == null)
                return false;

            return true;
        }
    }

    public class PancakeHouseIterator:Iterator
    {
        ArrayList menuItems;
        int currentPos = 0;

        public PancakeHouseIterator(ArrayList items)
        {
            this.menuItems = items;
        }

        public Object next()
        {
            return menuItems[currentPos++];
        }

        public bool hasNext()
        {
            if (currentPos >= menuItems.Count)
                return false;

            return true;
        }
    }
}

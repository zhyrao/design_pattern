using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Six
{
    class Fourniture
    {
    }

    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light On!");
        }
        public void off()
        {
            Console.WriteLine("Light Off");
        }
    }



    public class Garage
    {
        public void up()
        {
            Console.WriteLine("Gargae door is opening");
        }

        public void down()
        {
            Console.WriteLine("Garage door is closing");
        }

        public void stop()
        {

        }

        public void lightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void lightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}

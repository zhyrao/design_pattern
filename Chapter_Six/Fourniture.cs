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

    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        string location;

        int speed;
        public CeilingFan(string loc)
        {
            this.location = loc;
            speed = OFF;
        }

        public int getSpeed()
        {
            return speed;
        }
        public void high()
        {
            speed = HIGH;
            Console.WriteLine("Fan High Speed");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("Fan medium Speed");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine("Fan low Speed");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine("Fan Off");
        }
    }

    public class TV
    {
        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void off()
        {
            Console.WriteLine("TV is off");
        }
    }
}

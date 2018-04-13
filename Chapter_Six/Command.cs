using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Six
{
    // 命令接口
    public interface Command
    {
        void excute();
    }

    // 什么有没有的命令
    public class NoCommand : Command
    {
        public void excute() { }
    }

    // 打开灯命令
    public class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light l)
        {
            this.light = l;
        }

        public void excute()
        {
            light.on();
        }
    }
    // 关闭灯命令
    public class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light l)
        {
            this.light = l;
        }

        public void excute()
        {
            light.off();
        }
    }

    // 打开车库命令
    public class GarageOnCommand:Command
    {
        Garage garage;
        public GarageOnCommand(Garage g)
        {
            this.garage = g;
        }
        public void excute()
        {
            garage.up();
            garage.lightOn();
        }
    }


    // 关闭车库命令
    public class GarageOffCommand : Command
    {
        Garage garage;
        public GarageOffCommand(Garage g)
        {
            this.garage = g;
        }
        public void excute()
        {
            garage.down();
            garage.lightOff();
        }
    }
}

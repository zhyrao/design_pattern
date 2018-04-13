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
        void undo();
    }

    // 什么有没有的命令
    public class NoCommand : Command
    {
        public void excute() { }
        public void undo() { }
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

        public void undo()
        {
            light.off();
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

        public void undo()
        {
            light.on();
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

        public void undo()
        {
            garage.lightOff();
            garage.down();
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

        public void undo()
        {
            garage.up();
            garage.lightOn();
        }
    }

    // 风扇转速命令
    public class CeilingFanHighCommand:Command
    {
        CeilingFan ceilingFan;
        int previousSpeed;

        public CeilingFanHighCommand(CeilingFan fan)
        {
            ceilingFan = fan;
        }

        public void excute()
        {
            previousSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }

        public void undo()
        {
            if (previousSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (previousSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (previousSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else if (previousSpeed == CeilingFan.OFF)
                ceilingFan.off();
        }
    }

    // 风扇转速命令
    public class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int previousSpeed;

        public CeilingFanMediumCommand(CeilingFan fan)
        {
            ceilingFan = fan;
        }

        public void excute()
        {
            previousSpeed = ceilingFan.getSpeed();
            ceilingFan.medium();
        }

        public void undo()
        {
            if (previousSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (previousSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (previousSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else if (previousSpeed == CeilingFan.OFF)
                ceilingFan.off();
        }
    }

    // 风扇转速命令
    public class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        int previousSpeed;

        public CeilingFanLowCommand(CeilingFan fan)
        {
            ceilingFan = fan;
        }

        public void excute()
        {
            previousSpeed = ceilingFan.getSpeed();
            ceilingFan.low();
        }

        public void undo()
        {
            if (previousSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (previousSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (previousSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else if (previousSpeed == CeilingFan.OFF)
                ceilingFan.off();
        }
    }

    // 风扇转速命令
    public class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        int previousSpeed;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            ceilingFan = fan;
        }

        public void excute()
        {
            previousSpeed = ceilingFan.getSpeed();
            ceilingFan.off();
        }

        public void undo()
        {
            if (previousSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (previousSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (previousSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else if (previousSpeed == CeilingFan.OFF)
                ceilingFan.off();
        }
    }

    // 组合系列命令
    public class MacroCommand: Command
    {
        Command[] commands;

        public MacroCommand(Command[] cmds)
        {
            this.commands = cmds;
        }

        public void excute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].excute();
            }
        }

        public void undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].undo();
            }
        }
    }

    public class TVOnCommand:Command
    {
        TV tv;
        public TVOnCommand(TV tv)
        { this.tv = tv; }
        public void excute()
        {
            tv.on();
        }

        public void undo()
        {
            tv.off();
        }
    }

    public class TVOffCommand:Command
    {
        TV tv;
        public TVOffCommand(TV tv)
        { this.tv = tv; }

        public void excute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }
    }
}

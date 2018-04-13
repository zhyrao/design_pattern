using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Six
{
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public void setCommand(Command cmd)
        {
            this.slot = cmd;
        }

        public void buttonwasPressed()
        {
            slot.excute();
        }
    }

    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCmd, Command offCmd)
        {
            onCommands[slot] = onCmd;
            offCommands[slot] = offCmd;
        }

        public void onButtonWasPressed(int slot)
        {
            onCommands[slot].excute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPressed(int slot)
        {
            offCommands[slot].excute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonPressed()
        {
            undoCommand.undo();
        }

        public string CmdInfo()
        {
            string cmdInfos = null;
            cmdInfos += "\n------- Remote Control ------\n-";

            for (int i = 0; i < onCommands.Length; i++)
            {
                cmdInfos += "[slot " + i + "]" + onCommands[i].ToString() + "   " + offCommands[i].ToString() + "\n";
            }

            return cmdInfos;
        }

    }
}

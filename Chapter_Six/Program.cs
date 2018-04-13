using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Six
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl simRemoteControl = new SimpleRemoteControl();

            //Light light = new Light();
            //LightOnCommand lightonCmd = new LightOnCommand(light);

            //Garage garage = new Garage();
            //GarageOnCommand garageOnCmd = new GarageOnCommand(garage);
            //GarageOffCommand garageOffCmd = new GarageOffCommand(garage);

            //simRemoteControl.setCommand(lightonCmd);
            //simRemoteControl.buttonwasPressed();

            //simRemoteControl.setCommand(garageOnCmd);
            //simRemoteControl.buttonwasPressed();

            //simRemoteControl.setCommand(garageOffCmd);
            //simRemoteControl.buttonwasPressed();

            RemoteControl remoteControl = new RemoteControl();

            //Light light = new Light();
            //LightOnCommand lightonCmd = new LightOnCommand(light);
            //LightOffCommand lightoffCmd = new LightOffCommand(light);
            //Garage garage = new Garage();
            //GarageOnCommand garageOnCmd = new GarageOnCommand(garage);
            //GarageOffCommand garageOffCmd = new GarageOffCommand(garage);

            //remoteControl.SetCommand(0, lightonCmd, lightoffCmd);
            //remoteControl.SetCommand(1, garageOnCmd, garageOffCmd);

            //Console.WriteLine(remoteControl.CmdInfo());

            //remoteControl.onButtonWasPressed(0);
            //Console.WriteLine();
            //remoteControl.onButtonWasPressed(1);
            //Console.WriteLine();
            //remoteControl.offButtonWasPressed(1);
            //Console.WriteLine();
            //remoteControl.offButtonWasPressed(0);

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanMediumCommand ceilingFanMediumCmd = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHighCmd = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCmd = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMediumCmd, ceilingFanOffCmd);
            remoteControl.SetCommand(1, ceilingFanHighCmd, ceilingFanOffCmd);

            Console.WriteLine(remoteControl.CmdInfo());

            remoteControl.onButtonWasPressed(0);
            remoteControl.offButtonWasPressed(0);
            remoteControl.undoButtonPressed();

            remoteControl.onButtonWasPressed(1);
            remoteControl.offButtonWasPressed(1);
            remoteControl.undoButtonPressed();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using CommandPattern.CommandMacros;
using CommandPattern.Commands;

namespace CommandPattern
{
    class RemoteLoaderProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ON | 1 OFF Remote example");
            RemoteControl remoteControl = new RemoteControl(1);

            // Creating objects to control
            Light garageLight = new Light("Garage Light");

            // Creating commands for objects to control
            LightOnCommand garageLightOnCommand = new LightOnCommand(garageLight);
            LightOffCommand garageLightOffCommand = new LightOffCommand(garageLight);

            // Loading commands into the remoteControl
            remoteControl.SetCommand(0, garageLightOnCommand, garageLightOffCommand);

            // Simulating button clicks
            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);

            /*
             * MACRO COMMAND EXAMPLE
             */
            Console.WriteLine("1 ON | 1 OFF Remote macro example");

            // Creating objects to control
            ICommand[] onCommandCollection = new ICommand[5];
            ICommand[] offCommandCollection = new ICommand[5];
            for (int i = 0; i < 5; i++)
            {
                Light light = new Light("Light #" + (i+1));
                onCommandCollection[i] = new LightOnCommand(light);
            }
            for (int i = 0; i < 5; i++)
            {
                Light light = new Light("Light #" + (i+1));
                offCommandCollection[i] = new LightOffCommand(light);
            }

            // Inserting command collection into a Macro Command
            MacroCommand lightsOnMacro = new MacroCommand(onCommandCollection);
            MacroCommand lightsOffMacro = new MacroCommand(offCommandCollection);

            // Loading macro commands into the remoteControl
            remoteControl.SetCommand(0, lightsOnMacro, lightsOffMacro);

            // Simulating button clicks
            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);
        }
    }
}

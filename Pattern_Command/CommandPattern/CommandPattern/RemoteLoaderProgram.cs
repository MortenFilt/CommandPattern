using System;
using CommandPattern.Commands;

namespace CommandPattern
{
    class RemoteLoaderProgram
    {
        static void Main(string[] args)
        {
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
        }
    }
}

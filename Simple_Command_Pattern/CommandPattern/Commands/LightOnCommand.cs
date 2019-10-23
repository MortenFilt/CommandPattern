using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        // This should undo the Execute action, eg. if Execute is On, undo is Off
        // If Execute is ++, undo is --
        public void Undo()
        {
            _light.Off();
        }
    }
}

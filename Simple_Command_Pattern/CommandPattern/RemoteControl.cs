using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        private ICommand[] _onCommand;
        private ICommand[] _offCommand;

        public RemoteControl(int slotsOnRemote)
        {
            // Example use of exception where parameter is an invalid value
            if (slotsOnRemote < 1)
            {
                throw new System.ArgumentException("RemoteControl Parameter cannot be less than 1", "slotsOnRemote");
            }

            // Create array of command slots/keys on remote
            _onCommand = new ICommand[slotsOnRemote];
            _offCommand = new ICommand[slotsOnRemote];

            // Fill all slots with NoCommand
            for (int i = 0; i < slotsOnRemote; i++)
            {
                _onCommand[i] = new NoCommand();
                _offCommand[i] = new NoCommand();
            }
            
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            // Example use of exception where parameter causes an exception, here slot is out of range
            try
            {
                _onCommand[slot] = onCommand;
                _offCommand[slot] = offCommand;
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("RemoteControl.setCommand Parameter is out of range", "slot", ex);
                throw argEx;
            }

        }

        public void OnButtonPushed(int slot)
        {
            _onCommand[slot].Execute();
        }

        public void OffButtonPushed(int slot)
        {
            _offCommand[slot].Execute();
        }
    }
}

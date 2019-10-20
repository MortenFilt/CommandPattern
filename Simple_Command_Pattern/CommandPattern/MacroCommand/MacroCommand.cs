namespace CommandPattern.CommandMacros
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        public MacroCommand(ICommand[] commandCollection)
        {
            _commands = commandCollection;
        }

        public void Execute()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }
    }
}

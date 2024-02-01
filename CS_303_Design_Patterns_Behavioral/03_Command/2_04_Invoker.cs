namespace _03_Command
{
    // Invoker class that will execute the command
    public class User
    {
        private ICommand2 command;

        public void SetCommand(ICommand2 command)
        {
            this.command = command;
        }

        public void ExecuteOperation()
        {
            command.Execute();
        }
    }
}

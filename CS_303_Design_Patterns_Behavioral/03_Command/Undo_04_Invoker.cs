
namespace _03_Command
{
    // Invoker class
    public class Invoker
    {
        private ICommandUndo command;
        private Stack<ICommandUndo> commandHistory = new Stack<ICommandUndo>();

        public void SetCommand(ICommandUndo command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
            commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (commandHistory.Count > 0)
            {
                ICommandUndo lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }
    }
}

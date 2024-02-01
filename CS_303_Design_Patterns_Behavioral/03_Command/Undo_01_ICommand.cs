namespace _03_Command
{
    // Command interface
    public interface ICommandUndo
    {
        void Execute();
        void Undo();
    }
}

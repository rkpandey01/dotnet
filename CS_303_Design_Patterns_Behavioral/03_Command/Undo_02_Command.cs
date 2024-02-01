namespace _03_Command
{
    // Concrete Command for adding text
    public class AddTextCommand : ICommandUndo
    {
        private string addedText;
        private Receiver receiver;

        public AddTextCommand(Receiver receiver, string text)
        {
            this.receiver = receiver;
            addedText = text;
        }

        public void Execute()
        {
            receiver.AddText(addedText);
        }

        public void Undo()
        {
            receiver.RemoveText(addedText);
        }
    }
}

namespace _03_Command
{
    // Concrete command for saving the document
    public class SaveCommand : ICommand2
    {
        private DocumentProcessor documentProcessor;

        public SaveCommand(DocumentProcessor processor)
        {
            this.documentProcessor = processor;
        }

        public void Execute()
        {
            documentProcessor.Save();
        }
    }

    // Concrete command for printing the document
    public class PrintCommand : ICommand2
    {
        private DocumentProcessor documentProcessor;

        public PrintCommand(DocumentProcessor processor)
        {
            this.documentProcessor = processor;
        }

        public void Execute()
        {
            documentProcessor.Print();
        }
    }

    // Concrete command for undoing the last operation
    public class UndoCommand : ICommand2
    {
        private DocumentProcessor documentProcessor;

        public UndoCommand(DocumentProcessor processor)
        {
            this.documentProcessor = processor;
        }

        public void Execute()
        {
            documentProcessor.Undo();
        }
    }

}

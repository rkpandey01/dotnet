namespace _03_Command
{
    // Receiver class representing the Document Processor
    public class DocumentProcessor
    {
        private string documentContent;

        public void Save()
        {
            // Simulate saving the document
            Console.WriteLine("Document saved successfully.");
        }

        public void Print()
        {
            // Simulate printing the document
            Console.WriteLine("Document printed successfully.");
        }

        public void Undo()
        {
            // Simulate undoing the last operation
            Console.WriteLine("Undoing the last operation.");
        }

        // Other document processing methods...
    }
}

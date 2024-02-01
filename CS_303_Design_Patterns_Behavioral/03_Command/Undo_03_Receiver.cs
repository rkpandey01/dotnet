using System.Text;

namespace _03_Command
{
    // Receiver class
    public class Receiver
    {
        private StringBuilder text = new StringBuilder();

        public void AddText(string addedText)
        {
            text.Append(addedText);
            Console.WriteLine("Text added: " + addedText);
        }

        public void RemoveText(string addedText)
        {
            int lastIndex = text.ToString().LastIndexOf(addedText);
            if (lastIndex != -1)
            {
                text.Remove(lastIndex, addedText.Length);
                Console.WriteLine("Text removed: " + addedText);
            }
        }

        public void ShowText()
        {
            Console.WriteLine("Current Text: " + text);
        }
    }

}

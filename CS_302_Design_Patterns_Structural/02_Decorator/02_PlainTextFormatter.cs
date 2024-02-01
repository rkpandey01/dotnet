namespace _02_Decorator
{
    public class PlainTextFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }

}

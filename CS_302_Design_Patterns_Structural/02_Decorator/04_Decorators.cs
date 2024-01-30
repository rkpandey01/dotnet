namespace _02_Decorator
{
    public class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override string Format(string text)
        {
            return $"[Bold] {_textFormatter.Format(text)} [/Bold]";
        }
    }

    public class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override string Format(string text)
        {
            return $"[Italic] {_textFormatter.Format(text)} [/Italic]";
        }
    }

}

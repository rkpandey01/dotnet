namespace _02_Decorator
{
    public abstract class TextDecorator : ITextFormatter
    {
        protected ITextFormatter _textFormatter;

        public TextDecorator(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }

        public virtual string Format(string text)
        {
            return _textFormatter.Format(text);
        }
    }

}

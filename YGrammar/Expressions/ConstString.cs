namespace YGrammar.Expressions
{
    public class ConstString
        : BaseExpression
    {
        public string Value { get; }

        public ConstString(string value)
        {
            Value = value;
        }
    }
}

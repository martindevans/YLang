namespace YGrammar.Expressions
{
    public class ConstNumber
        : BaseExpression
    {
        public decimal Number { get; }

        public ConstNumber(decimal number)
        {
            Number = number;
        }
    }
}

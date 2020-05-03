namespace YGrammar.Expressions
{
    public class FieldAccess
        : BaseExpression
    {
        public FieldPath Path { get; }

        public FieldAccess(FieldPath path)
        {
            Path = path;
        }
    }
}

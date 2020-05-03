namespace YGrammar.Expressions
{
    public class CompilePanic
        : BaseExpression
    {
        public string Message { get; }

        public CompilePanic(string message)
        {
            Message = message;
        }
    }
}

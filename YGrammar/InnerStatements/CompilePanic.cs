using YGrammar.OuterStatements;

namespace YGrammar.InnerStatements
{
    public class CompilePanic
        : BaseOuterStatement
    {
        public string Message { get; }

        public CompilePanic(string message)
        {
            Message = message;
        }
    }
}

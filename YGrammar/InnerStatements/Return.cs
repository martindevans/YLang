using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class Return
        : BaseInnerStatement
    {
        public BaseExpression Expression { get; }

        public Return(BaseExpression expression)
        {
            Expression = expression;
        }
    }
}

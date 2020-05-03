using System.Collections.Generic;
using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class If
        : BaseInnerStatement
    {
        public BaseExpression Condition { get; }
        public IReadOnlyList<BaseInnerStatement> True { get; }
        public IReadOnlyList<BaseInnerStatement> False { get; }

        public If(BaseExpression condition, IReadOnlyList<BaseInnerStatement> @true, IReadOnlyList<BaseInnerStatement> @false)
        {
            Condition = condition;
            True = @true;
            False = @false;
        }
    }
}

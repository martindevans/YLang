using System.Collections.Generic;
using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class Call
        : BaseInnerStatement
    {
        public string Name { get; }
        public IReadOnlyList<BaseExpression> Parameters { get; }

        public Call(string name, IReadOnlyList<BaseExpression> parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}

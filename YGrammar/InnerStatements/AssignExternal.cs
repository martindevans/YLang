using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class AssignExternal
        : BaseInnerStatement
    {
        public string Name { get; }
        public BaseExpression Value { get; }

        public AssignExternal(string name, BaseExpression value)
        {
            Name = name;
            Value = value;
        }
    }
}

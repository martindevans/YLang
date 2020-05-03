using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class Assign
        : BaseInnerStatement
    {
        public FieldPath Field { get; }
        public BaseExpression Value { get; }

        public Assign(FieldPath field, BaseExpression value)
        {
            Field = field;
            Value = value;
        }
    }
}

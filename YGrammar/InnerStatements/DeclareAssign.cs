using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class DeclareAssign
        : BaseInnerStatement
    {
        public FieldDefinition Field { get; }
        public BaseExpression Value { get; }

        public DeclareAssign(FieldDefinition field, BaseExpression value)
        {
            Field = field;
            Value = value;
        }
    }
}

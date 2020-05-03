using YGrammar.Expressions;

namespace YGrammar.InnerStatements
{
    public class DeclareConst
        : BaseInnerStatement
    {
        public FieldDefinition Field { get; }
        public BaseExpression Value { get; }

        public DeclareConst(FieldDefinition field, BaseExpression value)
        {
            Field = field;
            Value = value;
        }
    }
}

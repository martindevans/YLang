
using YGrammar.Expressions;

namespace YGrammar
{
    public class Constant
    {
        public FieldDefinition Field { get; }
        public BaseExpression Expression { get; }

        public Constant(FieldDefinition field, BaseExpression expression)
        {
            Expression = expression;
            Field = field;
        }
    }
}

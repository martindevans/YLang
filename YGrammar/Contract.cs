using YGrammar.Expressions;

namespace YGrammar
{
    public enum ContractType
    {
        Requires,
        Ensures,
    }

    public class Contract
    {
        public ContractType Type { get; }
        public BaseExpression Expression { get; }

        public Contract(ContractType type, BaseExpression expression)
        {
            Type = type;
            Expression = expression;
        }
    }
}

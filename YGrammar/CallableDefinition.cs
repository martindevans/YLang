using System.Collections.Generic;
using YGrammar.InnerStatements;

namespace YGrammar
{
    public enum CallType
    {
        Goto,
        Inline
    }

    public class CallableDefinition
    {
        public Identifier Name { get; }
        public CallType CallType { get; }
        public Identifier? ReturnType { get; }
        public IReadOnlyList<BaseInnerStatement> Statements { get; }
        public IReadOnlyList<Contract> Contracts { get; }
        public IReadOnlyList<ParameterDefinition> Parameters { get; }

        public CallableDefinition(Identifier name, CallType callType, IReadOnlyList<ParameterDefinition> parameters, Identifier? returnType, IReadOnlyList<BaseInnerStatement> statements, IReadOnlyList<Contract> contracts)
        {
            Name = name;
            CallType = callType;
            Parameters = parameters;
            ReturnType = returnType;
            Statements = statements;
            Contracts = contracts;
        }
    }
}

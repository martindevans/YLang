using System.Collections.Generic;
using YGrammar.InnerStatements;

namespace YGrammar.OuterStatements
{
    public class Block
        : BaseOuterStatement
    {
        public IReadOnlyList<BaseInnerStatement> Statements { get; }
        public string Label { get; }

        public Block(IReadOnlyList<BaseInnerStatement> statements, string label)
        {
            Statements = statements;
            Label = label;
        }
    }
}

using System.Collections.Generic;
using YGrammar.InnerStatements;

namespace YGrammar.OuterStatements
{
    public class Line
        : BaseOuterStatement
    {
        public IReadOnlyList<BaseInnerStatement> Statements { get; }
        public string? Label { get; }

        public Line(IReadOnlyList<BaseInnerStatement> statements, string? label = null)
        {
            Statements = statements;
            Label = label;
        }
    }
}

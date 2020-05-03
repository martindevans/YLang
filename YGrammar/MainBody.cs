using System.Collections.Generic;
using YGrammar.OuterStatements;

namespace YGrammar
{
    public class MainBody
    {
        public IReadOnlyList<BaseOuterStatement> Statements { get; }

        public MainBody(IReadOnlyList<BaseOuterStatement> statements)
        {
            Statements = statements;
        }
    }
}

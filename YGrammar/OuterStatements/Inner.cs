using YGrammar.InnerStatements;

namespace YGrammar.OuterStatements
{
    public class Inner
        : BaseOuterStatement
    {
        public BaseInnerStatement Statement { get; }

        public Inner(BaseInnerStatement statement)
        {
            Statement = statement;
        }
    }
}

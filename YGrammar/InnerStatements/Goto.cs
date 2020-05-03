namespace YGrammar.InnerStatements
{
    public class Goto
        : BaseInnerStatement
    {
        public string Label { get; }

        public Goto(string label)
        {
            Label = label;
        }
    }
}

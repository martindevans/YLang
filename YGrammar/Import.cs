namespace YGrammar
{
    public class Import
    {
        public string Path { get; }
        public Identifier? NameSpace { get; }

        public Import(string path, Identifier? nameSpace = null)
        {
            Path = path;
            NameSpace = nameSpace;
        }
    }
}

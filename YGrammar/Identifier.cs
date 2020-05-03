using System.Collections.Generic;

namespace YGrammar
{
    public class Identifier
    {
        public IReadOnlyList<string> Path { get; }

        public Identifier(IReadOnlyList<string> path)
        {
            Path = path;
        }
    }
}

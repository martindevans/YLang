using System.Collections.Generic;

namespace YGrammar
{
    public class FieldPath
    {
        public IReadOnlyList<string> Path { get; }

        public FieldPath(IReadOnlyList<string> path)
        {
            Path = path;
        }
    }
}

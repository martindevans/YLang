using System.Collections.Generic;

namespace YGrammar
{
    public class StructDefinition
    {
        public Identifier Name { get; }
        public IReadOnlyList<FieldDefinition> Fields { get; }

        public StructDefinition(Identifier name, IReadOnlyList<FieldDefinition> fields)
        {
            Name = name;
            Fields = fields;
        }
    }
}

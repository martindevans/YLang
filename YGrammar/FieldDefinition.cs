namespace YGrammar
{
    public class FieldDefinition
    {
        public Identifier Name { get; }
        public Identifier Type { get; }

        public FieldDefinition(Identifier name, Identifier type)
        {
            Name = name;
            Type = type;
        }
    }
}

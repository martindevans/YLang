namespace YGrammar
{
    public class ParameterDefinition
    {
        public FieldDefinition Field { get; }
        public bool Copy { get; }

        public ParameterDefinition(FieldDefinition field, bool copy)
        {
            Field = field;
            Copy = copy;
        }
    }
}

using System.Collections.Generic;

namespace YTypes
{
    public class StructType
        : BaseType
    {
        public string Name { get; }
        public IReadOnlyList<(string, BaseType)> Fields { get; }

        public StructType(string name, IReadOnlyList<(string, BaseType)> fields)
        {
            Fields = fields;
            Name = name;
        }

        public override bool IsAssignableFrom(BaseType other)
        {
            throw new System.NotImplementedException();
        }
    }
}

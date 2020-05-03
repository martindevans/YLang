using System;

namespace YTypes
{
    public class EnumType
        : BaseType
    {
        public string Name { get; }
        public BaseType BaseType { get; }

        public EnumType(string name, BaseType baseType)
        {
            Name = name;
            BaseType = baseType;
        }

        public override bool IsAssignableFrom(BaseType other)
        {
            throw new NotImplementedException();
        }
    }
}

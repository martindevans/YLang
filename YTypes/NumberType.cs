using System;

namespace YTypes
{
    public class NumberType
        : BaseType
    {
        public override bool IsAssignableFrom(BaseType other)
        {
            return other switch {
                BoolType _   => true,
                NumberType _ => true,

                StructType _ => false,
                StringType _ => false,

                EnumType e   => IsAssignableFrom(e.BaseType),

                _ => throw new ArgumentOutOfRangeException(nameof(other))
            };
        }
    }
}

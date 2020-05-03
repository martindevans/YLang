using System;

namespace YTypes
{
    public class StringType
        : BaseType
    {
        public override bool IsAssignableFrom(BaseType other)
        {
            return other switch {
                StringType _ => true,

                BoolType _   => false,
                NumberType _ => false,
                StructType _ => false,
                
                EnumType e   => IsAssignableFrom(e.BaseType),

                _ => throw new ArgumentOutOfRangeException(nameof(other))
            };
        }
    }
}

namespace YTypes
{
    public class BoolType
        : BaseType
    {
        public override bool IsAssignableFrom(BaseType other)
        {
            return other is BoolType;
        }
    }
}

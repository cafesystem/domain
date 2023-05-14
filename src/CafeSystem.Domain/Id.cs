using System.Collections.Generic;

namespace CafeSystem.Domain;

public class Id<TKey> : ValueObject
{
    public TKey Value { get; protected set; }

    public override bool Equals(object obj) 
        => obj != null && obj.GetType() == this.GetType() && this.Value.Equals((object)(obj as Id<TKey>).Value);

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Value.ToString();
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
namespace CafeSystem.Domain.Contracts;

/// <summary>
/// An Entity is a representation of an object in the domain. It is defined by its identity,
/// rather than its attributes. It encapsulates the state of that object through its attributes.
/// </summary>
public interface IEntity<TId>
{
    
    TId Id { get; }
}
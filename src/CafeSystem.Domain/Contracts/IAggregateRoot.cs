namespace CafeSystem.Domain.Contracts;

/// <summary>
/// The Aggregate Root is the parent Entity to all other Entities and Value Objects within the Aggregate.
/// </summary>
public interface IAggregateRoot<TId> : IEntity<TId>
{
    
    int Version { get; }
    
    
}
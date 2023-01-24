using System;
using System.Collections.Generic;
using CafeSystem.Domain.Contracts;

namespace CafeSystem.Domain;

/// <inheritdoc cref="IAggregateRoot" />
public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot<TId>
{
    private List<IDomainEvent>? _domainEvents;
    
    public int Version { get; }
    
    
    public IReadOnlyCollection<IDomainEvent?> GetDomainEvents()
    {
        return _domainEvents?.AsReadOnly();
    }

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents ??= new List<IDomainEvent>();
        _domainEvents.Add(domainEvent);
    }

    public void RemoveAllDomainEvents()
    {
        _domainEvents?.Clear();
    }

    public void RemoveDomainEvent(IDomainEvent domainEvent)
    {
        if (domainEvent is null)
            throw new ArgumentNullException(nameof(domainEvent));
        
        _domainEvents?.Remove(domainEvent);
    }
}
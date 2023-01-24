using System;
using CafeSystem.Domain.Contracts;
#pragma warning disable CS1591

namespace CafeSystem.Domain;

/// <inheritdoc />
public abstract class DomainEvent : IDomainEvent
{
    
    public DomainEvent()
    {
        Id = Guid.NewGuid();
        PublishedDateTime = DateTime.UtcNow;
    }
    
    public Guid Id { get; }
    
    public DateTime PublishedDateTime { get; }

    public int Version { get; } = 1;
}
using System;

namespace CafeSystem.Domain.Contracts;

/// <summary>
/// An event is something that has happened in the past. A domain event is,
/// something that happened in the domain that you want other parts of the same domain (in-process) to be aware of.
/// The notified parts usually react somehow to the events.
/// </summary>
public interface IDomainEvent
{
    Guid Id { get; }
    
    DateTime PublishedDateTime { get; }
    
    int Version { get; }
}
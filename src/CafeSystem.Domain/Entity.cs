using System.Collections.Generic;
using CafeSystem.Domain.Contracts;

namespace CafeSystem.Domain;

/// <inheritdoc /> 
public abstract class Entity<TId> : IEntity<TId>
{
    
    public TId Id { get; }
    
    
    public override bool Equals(object? obj)
    {
        if (obj is null || obj is not IEntity<TId>)
            return false;

        if (ReferenceEquals(this, obj))
            return true;

        if (this.GetType() != obj.GetType())
            return false;

        IEntity<TId> _obj = (IEntity<TId>)obj;
        
        return EqualityComparer<TId>.Default.Equals(_obj.Id, this.Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() ^ 31;
    }
    
    public static bool operator ==(Entity<TId> left, Entity<TId> right)
        => left?.Equals(right) ?? Equals(right, null);

    public static bool operator !=(Entity<TId> left, Entity<TId> right)
        => !(left == right);
    
}
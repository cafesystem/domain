using System;

namespace CafeSystem.Domain.Contracts;

public interface IAuditableEntity<TUserId>
{
    DateTime CreateDate { get; }
    
    DateTime? ModifyDate { get; }
    
    TUserId? CreatedByUserId { get; }
    
    TUserId? ModifiedByUserId { get; }
}
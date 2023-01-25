using System;

namespace CafeSystem.Domain;

/// <summary>
/// Represents an exception that a Domain object will throw.
/// </summary>
public class DomainException : Exception
{
    public DomainException()
    {
    }
    
    public DomainException(string message) : base(message) { }   
}
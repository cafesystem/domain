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


    public DomainException(string errorCode, string message): base(message)
    {
        ErrorCode = errorCode;
    }
    
    public string ErrorCode { get; protected set; }
}
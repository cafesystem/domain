namespace CafeSystem.Domain;

/// <summary>
/// Represents an Exception that a Domain object or service will throw
/// when a Business validation failed.
/// </summary>
public class DomainBusinessException : DomainException
{
    public DomainBusinessException() : base()
    {
    }

    public DomainBusinessException(string errorCode, string message = "") : base(message)
    {
        ErrorCode = errorCode;
    }
    
    public string ErrorCode { get; set; }
}
namespace Laba1;

public class RationalException : Exception
{
    public RationalException() { }
    public RationalException(string message) :
        base(message) { }
    public RationalException(string message, Exception e) : base(message, e) { }
    
}
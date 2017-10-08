[System.Serializable]
public class WrongParameterException : System.Exception
{
    public WrongParameterException() { }
    public WrongParameterException(string message) : base(message) { }
    public WrongParameterException(string message, System.Exception inner) : base(message, inner) { }
    protected WrongParameterException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
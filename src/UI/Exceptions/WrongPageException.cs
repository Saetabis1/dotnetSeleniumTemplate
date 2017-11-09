[System.Serializable]
public class WrongPageException : System.Exception
{
    public WrongPageException() { }
    public WrongPageException(string message) : base(message) { }
    public WrongPageException(string message, System.Exception inner) : base(message, inner) { }
    protected WrongPageException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
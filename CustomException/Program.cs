using System;
using System.IO;
using System.Runtime.Serialization;


namespace CustomException;


class Program
{
    static void Main(string[] args)
    {
        throw new CustomException("User is already logged in");
    }
}

public class CustomException : Exception
{
    public CustomException() : base() {} 
    public CustomException(string message) : base(message) {}
    public CustomException(string message, Exception innerException) : base(message, innerException) {}
    public CustomException(SerializationInfo info, StreamingContext context) : 
        base(info, context) {}
}
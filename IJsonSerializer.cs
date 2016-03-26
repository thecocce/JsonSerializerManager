using System;

namespace JsonSerializer
{
    /// <summary>
    /// Abstract serializer. 
    /// Abstract away Json de/serializer implementation details. 
    /// </summary>
    public interface IJsonSerializer
    {
        byte[] SerializeToByteArray(object obj);
        string SerializeToString<T>(T obj);
        T Deserialize<T>(string jsonString);
    }   
}

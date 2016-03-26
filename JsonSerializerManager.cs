using System;

namespace JsonSerializer
{
    /// <summary>
    /// Simple wrapper for IJsonSerializer implementations. 
    /// Additional domain specific functionality goes here. 
    /// </summary>
    public class JsonSerializerManager : IJsonSerializer
    {
        public JsonSerializerManager(IJsonSerializer serializer)
        {
            Serializer = serializer;
        }

        private readonly IJsonSerializer Serializer;

        public byte[] SerializeToByteArray(object obj)
        {
            return Serializer.SerializeToByteArray(obj);
        }

        public string SerializeToString<T>(T obj)
        {
            return Serializer.SerializeToString<T>(obj);
        }

        public T Deserialize<T>(string jsonString)
        {
            return Serializer.Deserialize<T>(jsonString);
        }
    }
}

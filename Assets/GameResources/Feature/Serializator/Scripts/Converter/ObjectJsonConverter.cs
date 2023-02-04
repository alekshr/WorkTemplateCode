using Newtonsoft.Json;

namespace WorkTemplateCode.Serializator
{
    /// <summary>
    /// Конвертирует объекты в json
    /// </summary>
    public class ObjectJsonConverter : IJsonConverter
    {
        public string Serialize<T>(T value) where T : class
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.SerializeObject(value, Formatting.Indented, settings);
        }

        public T Deserialize<T>(string json) where T : class =>
            JsonConvert.DeserializeObject<T>(json);
    }
}
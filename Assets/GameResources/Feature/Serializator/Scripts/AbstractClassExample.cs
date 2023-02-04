using JsonSubTypes;
using Newtonsoft.Json;

namespace WorkTemplateCode.Serializator
{
    [JsonConverter(typeof(JsonSubtypes), "TypeClassInherit")]
    [JsonSubtypes.KnownSubType(typeof(ModelExample), "ModelExample")]
    public abstract class AbstractClassExample
    {
        public int Age { get; set; }
    }
}

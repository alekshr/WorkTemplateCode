using JsonSubTypes;
using Newtonsoft.Json;

namespace WorkTemplateCode.Serializator
{
    [JsonConverter(typeof(JsonSubtypes), "TypeClassInherit")]
    [JsonSubtypes.KnownSubType(typeof(ModelExample), "ModelExample")]
    public interface InterfaceExample
    {
        public float Height { get; set; }
    }
}

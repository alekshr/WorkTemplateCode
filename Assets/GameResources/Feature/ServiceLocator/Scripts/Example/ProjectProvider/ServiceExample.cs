

namespace WorkTemplateCode.ServiceLocator.Example
{
    
    public class ServiceExample : IServiceExample
    {
        public ServiceExample(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; }
        public string Name { get; }
    }
}
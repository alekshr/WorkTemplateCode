using System;
using WorkTemplateCode.ServiceLocator.ProviderProject;

namespace WorkTemplateCode.ServiceLocator.Example
{
    public class ProjectServiceExampleProvider : AbstractProjectProviderService<IServiceExample>
    {
        protected IServiceLocator<IServiceExample> serviceExample = new ServiceLocator<IServiceExample>();

        protected override void Awake()
        {
            base.Awake();
            serviceExample.Register(new ServiceExample(25, "Project Provider Name"));
        }

        public override TP Get<TP>(Guid id = default) =>
            serviceExample.Get<TP>(id);
    }
}

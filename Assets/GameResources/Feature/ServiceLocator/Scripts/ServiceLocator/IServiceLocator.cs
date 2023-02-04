using System;


namespace WorkTemplateCode.ServiceLocator
{
    public interface IServiceLocator<T>
    {
        TP Register<TP>(TP service, Guid id = default) where TP : T;

        void Unregister<TP>(TP service, Guid id = default) where TP : T;
        
        TP Get<TP>(Guid id = default) where TP : T;
    }
}
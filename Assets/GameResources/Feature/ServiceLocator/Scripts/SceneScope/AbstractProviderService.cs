using System;
using UnityEngine;


namespace WorkTemplateCode.ServiceLocator.ProviderProject
{
    [DefaultExecutionOrder(-5000)]
    public abstract class AbstractProviderService<T> : MonoBehaviour
    {
        public static AbstractProviderService<T> Instance = default;

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
        protected virtual void OnDestroy() =>
            Instance = null;
        
        public abstract TP Get<TP>(Guid id = default) where TP : T;
    }
}
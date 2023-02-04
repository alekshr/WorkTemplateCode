using System;
using UnityEngine;

namespace WorkTemplateCode.ServiceLocator.ProviderProject
{
    [DefaultExecutionOrder(-6000)]

    public abstract class AbstractProjectProviderService<T> : MonoBehaviour
    {
        public static AbstractProjectProviderService<T> Instance = default;

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public abstract TP Get<TP>(Guid id = default) where TP : T;
    }
}
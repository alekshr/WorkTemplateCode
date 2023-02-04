using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;


namespace WorkTemplateCode.Provider
{
    [CreateAssetMenu]
    public class ProviderId : ScriptableObject
    {
        private readonly Guid id = Guid.NewGuid();
        
        public Guid Id => id;
    }
}
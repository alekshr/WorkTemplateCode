using System;
using System.Collections.Generic;
using UnityEngine;

namespace  WorkTemplateCode.ServiceLocator
{
    public class ServiceLocator<T> : IServiceLocator<T>
    {
        private Dictionary<Tuple<Type, Guid>, T> _mapService;

        public ServiceLocator()
        {
            _mapService = new Dictionary<Tuple<Type, Guid>, T>();
        }
    
        public TP Register<TP>(TP service, Guid id = default) where TP : T
        {
            Type typeService = service.GetType();
            Tuple<Type, Guid> key = Tuple.Create(typeService, id);

            if (_mapService.ContainsKey(key))
            {
                Debug.LogError($"Contains add service of type {typeService}. This type with id {id} already exists");
            }
            
            _mapService[key] = service;

            return service;
        }

        public void Unregister<TP>(TP service, Guid id = default) where TP : T
        {
            Type typeService = service.GetType();
            Tuple<Type, Guid> key = Tuple.Create(typeService, id);
            if (_mapService.ContainsKey(key))
            {
                _mapService.Remove(key);
            }
        }

        public TP Get<TP>(Guid id = default) where TP : T
        {
            Type typeService = typeof(TP);
            Tuple<Type, Guid> key = Tuple.Create(typeService, id);
            if (!_mapService.ContainsKey(key))
            {
                Debug.LogError($"Not contains service type {typeService} in container with id {id}");
            }

            return (TP)_mapService[key];
        }
    }
}


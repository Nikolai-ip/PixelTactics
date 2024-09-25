using System;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    public class ServiceContainer
    {
        private Dictionary<Type, IService> _services;
        public ServiceContainer()
        {
            _services = new Dictionary<Type, IService>();
        }
        public void Register<T>(IService service) where T : IService
        {
            if (_services.ContainsKey(typeof(T)))
                return;
        
            _services[typeof(T)] = service;
        }
    
        public void UnRegister<T>() where T : IService => _services.Remove(typeof(T));
    
        public T Get<T>() where T : IService
        {
            if (!_services.ContainsKey(typeof(T)))
                throw new ArgumentException("ServiceLocator.Get - have not this type");

            return (T)_services[typeof(T)];
        }
    }
}
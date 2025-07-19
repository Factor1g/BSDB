using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BusinessLogic
{
    public class DataServiceFactory : IDataServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DataServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetServiceForType(Type entityType)
        {
            //throw new InvalidOperationException($"Could not find service for type: {entityType.FullName}");
            var serviceType = typeof(IGenericDataService<>).MakeGenericType(entityType);

            var service = _serviceProvider.GetService(serviceType);
            Console.WriteLine("Looking for: " + serviceType.FullName);
            return service;
        }
    }
}

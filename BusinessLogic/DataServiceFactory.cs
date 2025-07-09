using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

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
            var genericType = typeof(GenericDataService<>).MakeGenericType(entityType);
            return _serviceProvider.GetService(genericType);
        }
    }
}

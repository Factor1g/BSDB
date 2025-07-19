using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IGenericDataService<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        IQueryable<T> SearchByName(string search);
        IQueryable<T> FilterByDateRange(DateTime start, DateTime end);
      
    }
}

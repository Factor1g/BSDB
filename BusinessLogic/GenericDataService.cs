using DataAccess;
using Model;
namespace BusinessLogic
{
    public class GenericDataService<T> where T : class, IEntity
    {
        protected readonly IBaseRepository<T> _repository;

        public GenericDataService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetAll().FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<T> SearchByMegnevezes(string search)
        {
            return _repository.GetAll()
                .Where(e => e.Name.ToLower().Contains(search.ToLower()));
        }

        public IQueryable<T> FilterByDateRange(DateTime start, DateTime end)
        {
            return _repository.GetAll()
                .Where(e => e.Date >= start && e.Date <= end);
        }

    }
}

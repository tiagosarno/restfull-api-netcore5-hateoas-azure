using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class ScheduleBusinessImplementation : IScheduleBusiness
    {
        private readonly IRepository<Schedule> _repository;

        public ScheduleBusinessImplementation(IRepository<Schedule> repository)
        {
            _repository = repository;
        }
        public List<Schedule> FindAll()
        {
            return _repository.FindAll();
        }

        public Schedule FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Schedule Create(Schedule schedule)
        {
            return _repository.Create(schedule);
        }

        public Schedule Update(Schedule schedule)
        {
            return _repository.Update(schedule);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

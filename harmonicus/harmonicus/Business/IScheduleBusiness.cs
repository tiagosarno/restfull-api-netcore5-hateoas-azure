using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IScheduleBusiness
    {
        Schedule Create(Schedule schedule);
        Schedule FindById(long id);
        List<Schedule> FindAll();
        Schedule Update(Schedule schedule);
        void Delete(long id);
    }
}

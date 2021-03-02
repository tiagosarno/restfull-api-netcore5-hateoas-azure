using harmonicus.Data.VO;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IScheduleBusiness
    {
        ScheduleVO Create(ScheduleVO schedule);
        ScheduleVO FindById(long id);
        List<ScheduleVO> FindAll();
        ScheduleVO Update(ScheduleVO schedule);
        void Delete(long id);
    }
}

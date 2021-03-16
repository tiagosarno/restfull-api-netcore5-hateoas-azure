using harmonicus.Data.VO;
using System;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IScheduleBusiness
    {
        ScheduleVO Create(ScheduleVO schedule);
        ScheduleVO FindById(Guid id);
        List<ScheduleVO> FindAll();
        ScheduleVO Update(ScheduleVO schedule);
        void Delete(Guid id);
    }
}

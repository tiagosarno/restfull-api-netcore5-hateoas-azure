using harmonicus.Data.Converter.Implementations;
using harmonicus.Data.VO;
using harmonicus.Model;
using harmonicus.Repository;
using System;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class ScheduleBusinessImplementation : IScheduleBusiness
    {
        private readonly IRepository<Schedule> _repository;

        private readonly ScheduleConverter _converter;

        public ScheduleBusinessImplementation(IRepository<Schedule> repository)
        {
            _repository = repository;
            _converter = new ScheduleConverter();
        }
        public List<ScheduleVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public ScheduleVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public ScheduleVO Create(ScheduleVO schedule)
        {
            var scheduleEntity = _converter.Parse(schedule);
            scheduleEntity = _repository.Create(scheduleEntity);
            return _converter.Parse(scheduleEntity);
        }

        public ScheduleVO Update(ScheduleVO schedule)
        {
            var scheduleEntity = _converter.Parse(schedule);
            scheduleEntity = _repository.Update(scheduleEntity);
            return _converter.Parse(scheduleEntity);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}

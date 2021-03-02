using harmonicus.Data.Converter.Contract;
using harmonicus.Data.VO;
using harmonicus.Model;
using System.Collections.Generic;
using System.Linq;

namespace harmonicus.Data.Converter.Implementations
{
    public class ScheduleConverter : IParser<ScheduleVO, Schedule>, IParser<Schedule, ScheduleVO>
    {
        public Schedule Parse(ScheduleVO origin)
        {
            if (origin == null) return null;
            return new Schedule
            {
                Id = origin.Id,
                Date = origin.Date,
                Hour = origin.Hour,
                PsychologistId = origin.PsychologistId,
                PatientId = origin.PatientId
            };
        }

        public ScheduleVO Parse(Schedule origin)
        {
            if (origin == null) return null;
            return new ScheduleVO
            {
                Id = origin.Id,
                Date = origin.Date,
                Hour = origin.Hour,
                PsychologistId = origin.PsychologistId,
                PatientId = origin.PatientId
            };
        }

        public List<Schedule> Parse(List<ScheduleVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ScheduleVO> Parse(List<Schedule> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}

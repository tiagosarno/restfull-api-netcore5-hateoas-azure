using System;

namespace harmonicus.Data.VO
{
    public class ScheduleVO
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Hour { get; set; }

        public long PsychologistId { get; set; }

        public long PatientId { get; set; }
    }
}

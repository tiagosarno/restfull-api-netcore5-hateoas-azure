using harmonicus.Hypermedia;
using harmonicus.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace harmonicus.Data.VO
{
    public class ScheduleVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Hour { get; set; }

        public long PsychologistId { get; set; }

        public long PatientId { get; set; }

        public long Status { get; set; }

        public DateTime NewDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

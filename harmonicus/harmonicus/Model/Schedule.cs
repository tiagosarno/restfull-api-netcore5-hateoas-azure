using harmonicus.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace harmonicus.Model

{
    [Table("schedule")]
    public class Schedule : BaseEntity
    {

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("hour")]
        public DateTime Hour { get; set; }

        [Column("psychologistId")]
        public long PsychologistId { get; set; }

        public Psychologist Psychologist { get; set; }

        [Column("patientId")]
        public long PatientId { get; set; }

        public Patient Patient { get; set; }

        [Column("status")]
        public long Status { get; set; }

        [Column("new_date")]
        public DateTime NewDate { get; set; }
    }
}

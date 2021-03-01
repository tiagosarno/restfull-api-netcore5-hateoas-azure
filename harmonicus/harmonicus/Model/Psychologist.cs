using harmonicus.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace harmonicus.Model
{
    [Table("psychologist")]
    public class Psychologist : BaseEntity
    {

        [Column("account_status")]
        public int AccountStatus { get; set; }

        [Column("registration_date")]
        public DateTime RegistrationDate { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("phone")]
        public long Phone { get; set; }

        [Column("phone_is_whatsapp")]
        public int PhoneIsWhatsApp { get; set; }

        [Column("crp")]
        public string Crp { get; set; }

        [Column("curriculum")]
        public string Curriculum { get; set; }

        [Column("how_find_harmonicus")]
        public string HowFindHarmonicus { get; set; }

        [Column("know_zoom")]
        public int KnowZoom { get; set; }

        [Column("know_google_meeting")]
        public int KnowGoogleMeeting { get; set; }

        [Column("know_skype")]
        public int KnowSkype { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("country")]
        public string Country { get; set; }

        public ICollection<Schedule> Schedules { get; set;  }
    }
}

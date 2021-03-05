using harmonicus.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace harmonicus.Model
{
    [Table("patient")]
    public class Patient : BaseEntity
    {

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("phone")]
        public long Phone { get; set; }

        [Column("phone_is_whatsapp")]
        public int PhoneIsWhatsApp { get; set; }

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

        [Column("avatar")]
        public string Avatar { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("status")]
        public int Status { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}

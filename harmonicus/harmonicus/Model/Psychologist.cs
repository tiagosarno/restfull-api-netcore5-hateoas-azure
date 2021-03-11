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

        [Column("avatar")]
        public string Avatar { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("crp_region")]
        public string CrpRegion { get; set; }

        [Column("file_crp")]
        public string FileCrp { get; set; }

        [Column("file_university_degree")]
        public string FileUniversityDegree { get; set; }

        [Column("lates_url")]
        public string LatesUrl { get; set; }

        [Column("profissional_title")]
        public string ProfissionalTitle { get; set; }

        [Column("short_profile_text")]
        public string ShortProfileText { get; set; }

        [Column("completed_training_courses")]
        public string CompletedTrainingCourses { get; set; }

        [Column("commercial_cep")]
        public string CommercialCep { get; set; }

        [Column("commercial_number")]
        public int CommercialNumber { get; set; }

        [Column("commercial_street")]
        public string CommercialStreet { get; set; }

        [Column("commercial_street_add_on")]
        public string CommercialStreetAddOn { get; set; }

        [Column("commercial_district")]
        public string CommercialDistrict { get; set; }

        [Column("commercial_city")]
        public string CommercialCity { get; set; }

        [Column("commercial_state")]
        public string CommercialState { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        public ICollection<Schedule> Schedules { get; set;  }
    }
}

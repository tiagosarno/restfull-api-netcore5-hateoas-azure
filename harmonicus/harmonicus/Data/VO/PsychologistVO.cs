using System;

namespace harmonicus.Data.VO
{
    public class PsychologistVO
    {
        public long Id { get; set; }

        public int AccountStatus { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Gender { get; set; }

        public long Phone { get; set; }

        public int PhoneIsWhatsApp { get; set; }

        public string Crp { get; set; }

        public string Curriculum { get; set; }

        public string HowFindHarmonicus { get; set; }

        public int KnowZoom { get; set; }

        public int KnowGoogleMeeting { get; set; }

        public int KnowSkype { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}

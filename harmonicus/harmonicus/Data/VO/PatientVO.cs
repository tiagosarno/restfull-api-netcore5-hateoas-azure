using System;

namespace harmonicus.Data.VO
{
    public class PatientVO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public long Phone { get; set; }

        public int PhoneIsWhatsApp { get; set; }

        public string HowFindHarmonicus { get; set; }

        public int KnowZoom { get; set; }

        public int KnowGoogleMeeting { get; set; }

        public int KnowSkype { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Avatar { get; set; }

        public DateTime BirthDate { get; set; }

        public int Status { get; set; }

        public string AuthorizationTerm { get; set; }

        public string ResponsibleCpf { get; set; }

    }
}

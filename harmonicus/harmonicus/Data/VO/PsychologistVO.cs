using harmonicus.Hypermedia;
using harmonicus.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace harmonicus.Data.VO
{
    public class PsychologistVO : ISupportsHyperMedia
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

        public string Avatar { get; set; }

        public DateTime BirthDate { get; set; }

        public string CrpRegion { get; set; }

        public string FileCrp { get; set; }

        public string FileUniversityDegree { get; set; }

        public string LatesUrl { get; set; }

        public string ProfissionalTitle { get; set; }

        public string ShortProfileText { get; set; }

        public string CompletedTrainingCourses { get; set; }

        public string CommercialCep { get; set; }

        public int CommercialNumber { get; set; }

        public string CommercialStreet { get; set; }

        public string CommercialStreetAddOn { get; set; }

        public string CommercialDistrict { get; set; }

        public string CommercialCity { get; set; }

        public string CommercialState { get; set; }

        public bool Enabled { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

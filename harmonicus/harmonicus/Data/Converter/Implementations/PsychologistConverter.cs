using harmonicus.Data.Converter.Contract;
using harmonicus.Data.VO;
using harmonicus.Model;
using System.Collections.Generic;
using System.Linq;

namespace harmonicus.Data.Converter.Implementations
{
    public class PsychologistConverter : IParser<PsychologistVO, Psychologist>, IParser<Psychologist, PsychologistVO>
    {
        public Psychologist Parse(PsychologistVO origin)
        {
            if (origin == null) return null;
            return new Psychologist
            {
                Id = origin.Id,
                AccountStatus = origin.AccountStatus,
                RegistrationDate = origin.RegistrationDate,
                Name = origin.Name,
                Email = origin.Email,
                Cpf = origin.Cpf,
                Gender = origin.Gender,
                Phone = origin.Phone,
                PhoneIsWhatsApp = origin.PhoneIsWhatsApp,
                Crp = origin.Crp,
                Curriculum = origin.Curriculum,
                HowFindHarmonicus = origin.HowFindHarmonicus,
                KnowZoom = origin.KnowZoom,
                KnowGoogleMeeting = origin.KnowGoogleMeeting,
                KnowSkype = origin.KnowSkype,
                City = origin.City,
                State = origin.State,
                Country = origin.Country
            };
        }

        public PsychologistVO Parse(Psychologist origin)
        {
            if (origin == null) return null;
            return new PsychologistVO
            {
                Id = origin.Id,
                AccountStatus = origin.AccountStatus,
                RegistrationDate = origin.RegistrationDate,
                Name = origin.Name,
                Email = origin.Email,
                Cpf = origin.Cpf,
                Gender = origin.Gender,
                Phone = origin.Phone,
                PhoneIsWhatsApp = origin.PhoneIsWhatsApp,
                Crp = origin.Crp,
                Curriculum = origin.Curriculum,
                HowFindHarmonicus = origin.HowFindHarmonicus,
                KnowZoom = origin.KnowZoom,
                KnowGoogleMeeting = origin.KnowGoogleMeeting,
                KnowSkype = origin.KnowSkype,
                City = origin.City,
                State = origin.State,
                Country = origin.Country
            };
        }

        public List<Psychologist> Parse(List<PsychologistVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PsychologistVO> Parse(List<Psychologist> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }


    }
}

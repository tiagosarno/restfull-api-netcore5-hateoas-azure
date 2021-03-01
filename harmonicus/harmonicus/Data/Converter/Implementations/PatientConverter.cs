using harmonicus.Data.Converter.Contract;
using harmonicus.Data.VO;
using harmonicus.Model;
using System.Collections.Generic;
using System.Linq;

namespace harmonicus.Data.Converter.Implementations
{
    public class PatientConverter : IParser<PatientVO, Patient>, IParser<Patient, PatientVO>
    {
        public Patient Parse(PatientVO origin)
        {
            if (origin == null) return null;
            return new Patient
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender,
                Email = origin.Email,
                Cpf = origin.Cpf
            };
        }

        public PatientVO Parse(Patient origin)
        {
            if (origin == null) return null;
            return new PatientVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender,
                Email = origin.Email,
                Cpf = origin.Cpf
            };
        }

        public List<Patient> Parse(List<PatientVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PatientVO> Parse(List<Patient> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        
    }
}

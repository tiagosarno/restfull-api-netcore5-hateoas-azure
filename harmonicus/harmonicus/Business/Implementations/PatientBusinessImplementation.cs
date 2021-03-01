using harmonicus.Data.Converter.Implementations;
using harmonicus.Data.VO;
using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class PatientBusinessImplementation : IPatientBusiness
    {
        private readonly IRepository<Patient> _repository;

        private readonly PatientConverter _converter;

        public PatientBusinessImplementation(IRepository<Patient> repository)
        {
            _repository = repository;
            _converter = new PatientConverter();
        }
        public List<PatientVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PatientVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PatientVO Create(PatientVO patient)
        {
            var patientEntity = _converter.Parse(patient);
            patientEntity = _repository.Create(patientEntity);
            return _converter.Parse(patientEntity);
        }

        public PatientVO Update(PatientVO patient)
        {
            var patientEntity = _converter.Parse(patient);
            patientEntity = _repository.Update(patientEntity);
            return _converter.Parse(patientEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

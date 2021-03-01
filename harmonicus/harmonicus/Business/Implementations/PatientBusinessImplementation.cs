using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class PatientBusinessImplementation : IPatientBusiness
    {
        private readonly IRepository<Patient> _repository;

        public PatientBusinessImplementation(IRepository<Patient> repository)
        {
            _repository = repository;
        }
        public List<Patient> FindAll()
        {
            return _repository.FindAll();
        }

        public Patient FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Patient Create(Patient patient)
        {
            return _repository.Create(patient);
        }

        public Patient Update(Patient patient)
        {
            return _repository.Update(patient);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

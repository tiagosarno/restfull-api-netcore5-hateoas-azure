using harmonicus.Model;
using harmonicus.Model.Context;
using harmonicus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace harmonicus.Business.Implementations
{
    public class PatientBusinessImplementation : IPatientBusiness
    {
        private readonly IPatientRepository _repository;

        public PatientBusinessImplementation(IPatientRepository repository)
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

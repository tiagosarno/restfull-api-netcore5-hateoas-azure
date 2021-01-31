using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPatientRepository
    {
        Patient Create(Patient patient);
        Patient FindById(long id);
        List<Patient> FindAll();
        Patient Update(Patient pateint);
        void Delete(long id);
        bool Exists(long id);
    }
}

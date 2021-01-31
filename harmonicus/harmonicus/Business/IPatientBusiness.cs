using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPatientBusiness
    {
        Patient Create(Patient patient);
        Patient FindById(long id);
        List<Patient> FindAll();
        Patient Update(Patient patient);
        void Delete(long id);
    }
}

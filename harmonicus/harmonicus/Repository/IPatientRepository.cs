using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Patient Disable(long id);

        List<Patient> FindByName(string firstName, string lastName);
    }
}

using harmonicus.Model;
using System;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Patient Disable(Guid id);

        List<Patient> FindByName(string firstName, string lastName);
    }
}

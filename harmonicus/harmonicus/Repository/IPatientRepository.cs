using harmonicus.Model;

namespace harmonicus.Repository
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Patient Disable(long id);
    }
}

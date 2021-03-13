using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPsychologistRepository : IRepository<Psychologist>
    {
        Psychologist Disable(long id);
        List<Psychologist> FindByName(string name);
    }
}

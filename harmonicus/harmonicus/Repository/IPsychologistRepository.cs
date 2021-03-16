using harmonicus.Model;
using System;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPsychologistRepository : IRepository<Psychologist>
    {
        Psychologist Disable(Guid id);
        List<Psychologist> FindByName(string name);
    }
}

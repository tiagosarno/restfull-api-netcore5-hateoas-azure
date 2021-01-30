using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Services
{
    public interface IPsychologistService
    {
        Psychologist Create(Psychologist psychologist);
        Psychologist FindById(long id);
        List<Psychologist> FindAll();
        Psychologist Update(Psychologist psychologist);
        void Delete(long id);
    }
}

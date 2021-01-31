using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Repository
{
    public interface IPsychologistRepository
    {
        Psychologist Create(Psychologist psychologist);
        Psychologist FindById(long id);
        List<Psychologist> FindAll();
        Psychologist Update(Psychologist psychologist);
        void Delete(long id);
        bool Exists(long id);
    }
}

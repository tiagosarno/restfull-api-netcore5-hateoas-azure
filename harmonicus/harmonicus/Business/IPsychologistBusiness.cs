using harmonicus.Model;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPsychologistBusiness
    {
        Psychologist Create(Psychologist psychologist);
        Psychologist FindById(long id);
        List<Psychologist> FindAll();
        Psychologist Update(Psychologist psychologist);
        void Delete(long id);
    }
}

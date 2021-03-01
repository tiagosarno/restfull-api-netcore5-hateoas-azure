using harmonicus.Data.VO;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPsychologistBusiness
    {
        PsychologistVO Create(PsychologistVO psychologist);
        PsychologistVO FindById(long id);
        List<PsychologistVO> FindAll();
        PsychologistVO Update(PsychologistVO psychologist);
        void Delete(long id);
    }
}

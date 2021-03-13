using harmonicus.Data.VO;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPsychologistBusiness
    {
        PsychologistVO Create(PsychologistVO psychologist);
        PsychologistVO FindById(long id);
        List<PsychologistVO> FindByName(string name);
        List<PsychologistVO> FindAll();
        PsychologistVO Update(PsychologistVO psychologist);
        PsychologistVO Disable(long id);
        void Delete(long id);
    }
}

using harmonicus.Data.VO;
using harmonicus.Hypermedia.Utils;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPsychologistBusiness
    {
        PsychologistVO Create(PsychologistVO psychologist);
        PsychologistVO FindById(long id);
        List<PsychologistVO> FindByName(string name);
        List<PsychologistVO> FindAll();
        PagedSearchVO<PsychologistVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
        PsychologistVO Update(PsychologistVO psychologist);
        PsychologistVO Disable(long id);
        void Delete(long id);
    }
}

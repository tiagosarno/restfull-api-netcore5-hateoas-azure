using harmonicus.Data.VO;
using harmonicus.Hypermedia.Utils;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPatientBusiness
    {
        PatientVO Create(PatientVO patient);
        PatientVO FindById(long id);
        List<PatientVO> FindByName(string firstName, string lastName);
        List<PatientVO> FindAll();
        PagedSearchVO<PatientVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
        PatientVO Update(PatientVO patient);
        PatientVO Disable(long id);
        void Delete(long id);
    }
}

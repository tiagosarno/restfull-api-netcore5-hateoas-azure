using harmonicus.Data.VO;
using harmonicus.Hypermedia.Utils;
using System;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPatientBusiness
    {
        PatientVO Create(PatientVO patient);
        PatientVO FindById(Guid id);
        List<PatientVO> FindByName(string firstName, string lastName);
        List<PatientVO> FindAll();
        PagedSearchVO<PatientVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
        PatientVO Update(PatientVO patient);
        PatientVO Disable(Guid id);
        void Delete(Guid id);
    }
}

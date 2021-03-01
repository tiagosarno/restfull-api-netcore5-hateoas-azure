using harmonicus.Data.VO;
using System.Collections.Generic;

namespace harmonicus.Business
{
    public interface IPatientBusiness
    {
        PatientVO Create(PatientVO patient);
        PatientVO FindById(long id);
        List<PatientVO> FindAll();
        PatientVO Update(PatientVO patient);
        void Delete(long id);
    }
}

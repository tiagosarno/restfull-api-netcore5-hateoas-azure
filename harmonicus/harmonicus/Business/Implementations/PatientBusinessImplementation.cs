using harmonicus.Data.Converter.Implementations;
using harmonicus.Data.VO;
using harmonicus.Hypermedia.Utils;
using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class PatientBusinessImplementation : IPatientBusiness
    {
        private readonly IPatientRepository _repository;

        private readonly PatientConverter _converter;

        public PatientBusinessImplementation(IPatientRepository repository)
        {
            _repository = repository;
            _converter = new PatientConverter();
        }
        public List<PatientVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PatientVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PatientVO> FindByName(string firstName, string lastName)
        {
            return _converter.Parse(_repository.FindByName(firstName, lastName));
        }

        public PagedSearchVO<PatientVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page)
        {            
            var sort = (!string.IsNullOrWhiteSpace(sortDirection)) && !sortDirection.Equals("desc") ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"select * from patient where 1=1 ";
            if (!string.IsNullOrWhiteSpace(name)) query = query + $" and first_name like '%{name}%' ";
            query += $" order by first_name {sort} limit {size} offset {offset}";

            string countQuery = @"select count(*) from patient where 1=1 ";
            if (!string.IsNullOrWhiteSpace(name)) countQuery = countQuery + $" and first_name like '%{name}%' ";

            var patients = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<PatientVO> {
                CurrentPage = page,
                List = _converter.Parse(patients),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }

        public PatientVO Create(PatientVO patient)
        {
            var patientEntity = _converter.Parse(patient);
            patientEntity = _repository.Create(patientEntity);
            return _converter.Parse(patientEntity);
        }

        public PatientVO Update(PatientVO patient)
        {
            var patientEntity = _converter.Parse(patient);
            patientEntity = _repository.Update(patientEntity);
            return _converter.Parse(patientEntity);
        }

        public PatientVO Disable(long id)
        {
            var patientEntity = _repository.Disable(id);
            return _converter.Parse(patientEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

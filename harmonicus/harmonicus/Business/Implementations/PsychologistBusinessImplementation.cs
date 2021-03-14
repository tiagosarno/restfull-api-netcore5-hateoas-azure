using harmonicus.Data.Converter.Implementations;
using harmonicus.Data.VO;
using harmonicus.Hypermedia.Utils;
using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class PsychologistBusinessImplementation : IPsychologistBusiness
    {
        private readonly IPsychologistRepository _repository;

        private readonly PsychologistConverter _converter;

        public PsychologistBusinessImplementation(IPsychologistRepository repository)
        {
            _repository = repository;
            _converter = new PsychologistConverter();
        }

        public List<PsychologistVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PsychologistVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PsychologistVO> FindByName(string name)
        {
            return _converter.Parse(_repository.FindByName(name));
        }

        public PagedSearchVO<PsychologistVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page)
        {
            var sort = (!string.IsNullOrWhiteSpace(sortDirection)) && !sortDirection.Equals("desc") ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"select * from psychologist where 1=1 ";
            if (!string.IsNullOrWhiteSpace(name)) query = query + $" and name like '%{name}%' ";
            query += $" order by name {sort} limit {size} offset {offset}";

            string countQuery = @"select count(*) from psychologist where 1=1 ";
            if (!string.IsNullOrWhiteSpace(name)) countQuery = countQuery + $" and name like '%{name}%' ";

            var psychologists = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<PsychologistVO>
            {
                CurrentPage = page,
                List = _converter.Parse(psychologists),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }

        public PsychologistVO Create(PsychologistVO psychologist)
        {
            var psychologistEntity = _converter.Parse(psychologist);
            psychologistEntity = _repository.Create(psychologistEntity);
            return _converter.Parse(psychologistEntity);
        }

        public PsychologistVO Update(PsychologistVO psychologist)
        {
            var psychologistEntity = _converter.Parse(psychologist);
            psychologistEntity = _repository.Update(psychologistEntity);
            return _converter.Parse(psychologistEntity);
        }

        public PsychologistVO Disable(long id)
        {
            var psychologistEntity = _repository.Disable(id);
            return _converter.Parse(psychologistEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

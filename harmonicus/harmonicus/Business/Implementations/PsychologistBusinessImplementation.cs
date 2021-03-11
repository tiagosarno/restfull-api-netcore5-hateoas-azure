using harmonicus.Data.Converter.Implementations;
using harmonicus.Data.VO;
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

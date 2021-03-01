using harmonicus.Model;
using harmonicus.Repository;
using System.Collections.Generic;

namespace harmonicus.Business.Implementations
{
    public class PsychologistBusinessImplementation : IPsychologistBusiness
    {
        private readonly IRepository<Psychologist> _repository;

        public PsychologistBusinessImplementation(IRepository<Psychologist> repository)
        {
            _repository = repository;
        }
        public List<Psychologist> FindAll()
        {
            return _repository.FindAll();
        }

        public Psychologist FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Psychologist Create(Psychologist psychologist)
        {
            return _repository.Create(psychologist);
        }

        public Psychologist Update(Psychologist psychologist)
        {
            return _repository.Update(psychologist);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

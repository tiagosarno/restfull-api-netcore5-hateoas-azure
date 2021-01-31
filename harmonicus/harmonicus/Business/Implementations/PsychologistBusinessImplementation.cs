using harmonicus.Model;
using harmonicus.Model.Context;
using harmonicus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace harmonicus.Business.Implementations
{
    public class PsychologistBusinessImplementation : IPsychologistBusiness
    {
        private readonly IPsychologistRepository _repository;

        public PsychologistBusinessImplementation(IPsychologistRepository repository)
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

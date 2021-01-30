using harmonicus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace harmonicus.Services.Implementations
{
    public class PsychologistServiceImplementation : IPsychologistService
    {
        private volatile int count;

        public Psychologist Create(Psychologist psychologist)
        {
            return psychologist;
        }

        public void Delete(long id)
        {
            // CODE
        }

        public List<Psychologist> FindAll()
        {
            List<Psychologist> psychologists = new List<Psychologist>();
            for (int i = 0; i < 8; i++)
            {
                Psychologist psychologist = MocPsychologist(i);
                psychologists.Add(psychologist);
            }
            return psychologists;
        }

        public Psychologist FindById(long id)
        {
            return new Psychologist
            {
                Id = IncrementAndGet(),
                FirstName = "Psy FirstName",
                LastName = "Psy LastName",
                Address = "Psy Address",
                Gender = "Psy Gender"
            };
        }

        public Psychologist Update(Psychologist psychologist)
        {
            return psychologist;
        }

        private Psychologist MocPsychologist(int i)
        {
            return new Psychologist
            {
                Id = IncrementAndGet(),
                FirstName = "Psy FirstName",
                LastName = "Psy LastName",
                Address = "Psy Address",
                Gender = "Psy Gender"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}

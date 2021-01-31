using harmonicus.Model;
using harmonicus.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace harmonicus.Repository.Implementations
{
    public class PatientRepositoryImplementation : IPatientRepository
    {
        private MySQLContext _context;

        public PatientRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        public List<Patient> FindAll()
        {
            return _context.Patients.ToList();
        }

        public Patient FindById(long id)
        {
            return _context.Patients.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Patient Create(Patient patient)
        {
            try
            {
                _context.Add(patient);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return patient;
        }

        public Patient Update(Patient patient)
        {
            if (!Exists(patient.Id)) return null;
            
            var result = _context.Patients.SingleOrDefault(p => p.Id.Equals(patient.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(patient);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }            
            return patient;
        }

        public void Delete(long id)
        {
            var result = _context.Patients.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Patients.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        public bool Exists(long id)
        {
            return _context.Patients.Any(p => p.Id.Equals(id));
        }
    }
}

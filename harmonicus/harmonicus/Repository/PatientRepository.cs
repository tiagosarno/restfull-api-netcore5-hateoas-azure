using harmonicus.Model;
using harmonicus.Model.Context;
using harmonicus.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace harmonicus.Repository
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(MySQLContext context) : base(context) { }

        public Patient Disable(long id)
        {
            if (!_context.Patients.Any(p => p.Id.Equals(id))) return null;
            var user = _context.Patients.SingleOrDefault(p => p.Id.Equals(id));
            if (user != null)
            {
                user.Enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return user;
        }

        public List<Patient> FindByName(string firstName, string lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _context.Patients.Where(
                    p => p.FirstName.Contains(firstName)
                    && p.LastName.Contains(lastName)).ToList();
            }
            else if (string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _context.Patients.Where(
                    p => p.LastName.Contains(lastName)).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return _context.Patients.Where(
                    p => p.FirstName.Contains(firstName)).ToList();
            }
            return null;

        }
    }
}

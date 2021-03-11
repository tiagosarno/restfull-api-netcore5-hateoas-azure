using harmonicus.Model;
using harmonicus.Model.Context;
using harmonicus.Repository.Generic;
using System;
using System.Linq;

namespace harmonicus.Repository
{
    public class PsychologistRepository : GenericRepository<Psychologist>, IPsychologistRepository
    {
        public PsychologistRepository(MySQLContext context) : base(context) { }

        public Psychologist Disable(long id)
        {
            if (!_context.Psychologists.Any(p => p.Id.Equals(id))) return null;
            var user = _context.Psychologists.SingleOrDefault(p => p.Id.Equals(id));
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
    }
}

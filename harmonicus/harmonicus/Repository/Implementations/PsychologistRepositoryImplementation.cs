﻿using harmonicus.Model;
using harmonicus.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace harmonicus.Repository.Implementations
{
    public class PsychologistRepositoryImplementation : IPsychologistRepository
    {
        private MySQLContext _context;

        public PsychologistRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        public List<Psychologist> FindAll()
        {
            return _context.Psychologists.ToList();
        }

        public Psychologist FindById(long id)
        {
            return _context.Psychologists.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Psychologist Create(Psychologist psychologist)
        {
            try
            {
                _context.Add(psychologist);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return psychologist;
        }

        public Psychologist Update(Psychologist psychologist)
        {
            if (!Exists(psychologist.Id)) return null;
            
            var result = _context.Psychologists.SingleOrDefault(p => p.Id.Equals(psychologist.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(psychologist);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }            
            return psychologist;
        }

        public void Delete(long id)
        {
            var result = _context.Psychologists.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Psychologists.Remove(result);
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
            return _context.Psychologists.Any(p => p.Id.Equals(id));
        }
    }
}
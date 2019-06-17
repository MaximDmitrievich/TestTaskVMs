using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestTaskVMs.Models;

namespace TestTaskVMs.Repositories
{
    public class VMRepository : IVMRepository, IDisposable
    {
        private readonly DbContext _context;
        public VMRepository(DbContext context)
        {
            _context = context;
        }
        public bool Add(VM item)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(VM item)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }

        public IEnumerable<VM> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(string id, VM item)
        {
            throw new System.NotImplementedException();
        }
    }
}
using Domain.Interfaces.Generic;
using Infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repository.Generics
{
    public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    {

        private readonly DbContextOptionsBuilder<ContextBase> _optionsBuilder;

        public RepositoryGeneric()
        {
            _optionsBuilder = new DbContextOptionsBuilder<ContextBase>();
        }

        public void Add(T Entity)
        {
            using (var banco = new ContextBase(_optionsBuilder.Options))
            {
                banco.Set<T>().Add(Entity);
                banco.SaveChanges();
            }
        }

        public void Delete(T Entity)
        {
            using (var banco = new ContextBase(_optionsBuilder.Options))
            {
                banco.Set<T>().Remove(Entity);
                banco.SaveChanges();
            }
        }

        public T GetEntity(int Id)
        {
            using (var banco = new ContextBase(_optionsBuilder.Options))
            {
                return banco.Set<T>().Find(Id);
            }
        }

        public List<T> List()
        {
            using (var banco = new ContextBase(_optionsBuilder.Options))
            {
                return banco.Set<T>().AsNoTracking().ToList();
            }
        }

        public void Update(T Entity)
        {
            using (var banco = new ContextBase(_optionsBuilder.Options))
            {
                banco.Set<T>().Update(Entity);
                banco.SaveChanges();
            }
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(true);
        }

        private void Dispose(bool isDispose)
        {
            if (!isDispose) return;
        }

        ~RepositoryGeneric()
        {
            Dispose(false);
        }
    }
}

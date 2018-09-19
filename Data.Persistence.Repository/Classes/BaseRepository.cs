using Data.Persistence.Core;
using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Data.Persistence.Repository.Classes
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        readonly IWorkUnitContext _workUnit;

        public IWorkUnit WorkUnit
        {
            get { return _workUnit; }
        }

        IWorkUnit IBaseRepository<Entity>.WorkUnit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BaseRepository(IWorkUnitContext workUnit)
        {
            _workUnit = workUnit;
        }

        public Entity Get(int Id)
        {
            return _workUnit.Set<Entity>().Find(Id);
        }

        public IEnumerable<Entity> GetAll()
        {
            return _workUnit.Set<Entity>().ToList();
        }

        public IEnumerable<Entity> Find(Expression<Func<Entity, bool>> predicate)
        {
            return _workUnit.Set<Entity>().Where(predicate);
        }

        public Entity FindSingleOrDefault(Expression<Func<Entity, bool>> predicate)
        {
            return _workUnit.Set<Entity>().Single(predicate);
        }

        public void Add(Entity entity)
        {
            _workUnit.Set<Entity>().Add(entity);
        }

        public void Delete(Entity entity)
        {
            _workUnit.Set<Entity>().Remove(entity);
        }

        public void Dispose()
        {
            _workUnit.Dispose();
        }
    }
}

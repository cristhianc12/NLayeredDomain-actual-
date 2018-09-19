using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Domain.Core
{
    public interface IBaseRepository<Entity> : IDisposable
    {
        IWorkUnit WorkUnit { get; set; }

        Entity Get(int Id);//SELECT * FROM House WHERE HouseID = ID
        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> FindSingleOrDefault(Expression<Func<Entity, bool>> predicate);

        void Add(Entity entity);

        void Delete(Entity entity);
    }
}

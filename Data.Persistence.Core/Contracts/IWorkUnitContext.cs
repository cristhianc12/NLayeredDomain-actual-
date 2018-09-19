using System;
using Domain.Core;
using System.Data.Entity;

namespace Data.Persistence.Core
{
    public interface IWorkUnitContext : IWorkUnit, IDisposable
    {
        IDbSet<House> Houses { get; }
        IDbSet<Entity> Set<Entity>() where Entity : class;

        void Attach<Entity>(Entity item) where Entity : class;

        void SetModified<Entity>(Entity item) where Entity : class;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Core;

namespace Data.Persistence.Core
{
    public class MainContext : DbContext, IWorkUnitContext
    {
        public MainContext() : base("DefaultConnection")
        {

        }

        IDbSet<House> _house;

        public IDbSet<House> Houses
        {
            get { return _house ?? (_house = base.Set<House>());  }
        }

        public new IDbSet<Entity> Set<Entity>() where Entity : class
        {
            return base.Set<Entity>();
        }

        public void Attach<Entity>(Entity item) where Entity : class
        {
            if(Entry(item).State == EntityState.Detached)
            {
                base.Set<Entity>().Attach(item);
            }
        }

        public void SetModified<Entity>(Entity item) where Entity : class
        {
            Entry(item).State = EntityState.Modified;
        }

        public int Complete()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}

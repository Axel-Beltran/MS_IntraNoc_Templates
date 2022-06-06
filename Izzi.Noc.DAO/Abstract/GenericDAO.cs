using Izzi.Noc.DAO.Objects;
using System.Data.Entity;
namespace Izzi.Noc.DAO.Abstract
{
    public abstract class GenericDAO<T, PK> where T : class
    {
        OracleDbContext context;
        public OracleDbContext Context
        {
            get
            {
                if (context == null)
                    context = new OracleDbContext();
                return context;
            }
        }
        protected GenericDAO()
        {
            Database.SetInitializer(new
            NullDatabaseInitializer<OracleDbContext>());
        }
        public virtual bool Create(T t)
        {
            using (Context)
            {
                Context.Set<T>().Add(t);
                Context.SaveChanges();
            }
            return true;
        }
        public virtual bool Persist(T t, PK pk)
        {
            using (Context)
            {
                T entityDB = Context.Set<T>().Find(pk);
                if (entityDB == null)
                {
                    Context.Set<T>().Add(t);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    Context.Entry(entityDB).CurrentValues.SetValues(t);
                    Context.SaveChanges();
                    return true;
                }
            }
        }
        public virtual bool Update(T t, T entityDB)
        {
            using (context)
            {
                Context.Entry(entityDB).CurrentValues.SetValues(t);
                Context.SaveChanges();
            }
            return true;
        }
        public virtual T GetById(PK pk)
        {
            return Context.Set<T>().Find(pk);
        }
    }
}
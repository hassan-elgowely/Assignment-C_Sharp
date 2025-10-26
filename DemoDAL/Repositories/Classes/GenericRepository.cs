using DemoDAL.Data.Contexts;
using DemoDAL.Model.Shared;
using DemoDAL.Repositories.Interfaces;


namespace DemoDAL.Repositories.Classes
{
    public class GenericRepository<TEntity>(ApplicationDbContext _context) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll(bool notracking = false)
        {
            if (notracking) return _context.Set<TEntity>().Where(Entity=>Entity.IsDeleted==false).ToList();
            return _context.Set<TEntity>().AsNoTracking().Where(Entity => Entity.IsDeleted == false).ToList();
        }

        public TEntity? GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }



    }
}

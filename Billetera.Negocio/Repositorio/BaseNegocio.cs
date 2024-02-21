using Billetera.Negocio.Connection;
using Billetera.Negocio.Repositorio.Interfaces;
using System.Linq.Expressions;

namespace Billetera.Negocio.Repositorio
{
    public class BaseNegocio<T> : BLLContext, IBaseNegocio<T> where T : class
    {
        public bool Delete(T model)
        {
            _context.Set<T>().Remove(model);
            return Save();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetAllByCondition(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).ToList();
        }

        public T GetByCondition(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).SingleOrDefault();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Insert(T model)
        {
            _context.Set<T>().Add(model);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(T model)
        {
            _context.Set<T>().Update(model);
            return Save();
        }
    }
}

using System.Linq.Expressions;

namespace Billetera.Negocio.Repositorio.Interfaces
{
    public interface IBaseNegocio<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAllByCondition(Expression<Func<T, bool>> where);
        T GetByCondition(Expression<Func<T, bool>> where);
        T GetById(int id);

        bool Save();
        bool Insert(T model);
        bool Update(T model);
        bool Delete(T model);
    }
}

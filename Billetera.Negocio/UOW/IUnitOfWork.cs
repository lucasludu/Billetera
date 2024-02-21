using Billetera.Negocio.Repositorio.Interfaces;

namespace Billetera.Negocio.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriaNegocio Categoria { get; }
        IMovimientoNegocio Movimiento { get; }
        ITipoMovimientoNegocio TipoMovimiento { get; }
        IUsuarioNegocio Usuario { get; }
    }
}

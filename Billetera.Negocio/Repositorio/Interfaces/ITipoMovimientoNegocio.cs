using Billetera.Models;

namespace Billetera.Negocio.Repositorio.Interfaces
{
    public interface ITipoMovimientoNegocio : IBaseNegocio<TipoMovimiento>
    {
        List<TipoMovimiento> GetListByCombo();
    }
}

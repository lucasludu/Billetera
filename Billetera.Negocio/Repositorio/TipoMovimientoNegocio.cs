using Billetera.Models;
using Billetera.Negocio.Repositorio.Interfaces;
using Billetera.Negocio.UOW;

namespace Billetera.Negocio.Repositorio
{
    public class TipoMovimientoNegocio : BaseNegocio<TipoMovimiento>, ITipoMovimientoNegocio
    {
        public List<TipoMovimiento> GetListByCombo()
        {
            var tipoMovimientoList = new UnitOfWork().TipoMovimiento.GetAll();
            tipoMovimientoList.Add(new TipoMovimiento(0, "TODOS"));
            return tipoMovimientoList.OrderBy(a => a.Id).ToList();
        }
    }
}

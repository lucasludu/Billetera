using Billetera.Models;
using Billetera.Models.Dto;

namespace Billetera.Negocio.Repositorio.Interfaces
{
    public interface IMovimientoNegocio : IBaseNegocio<Movimiento>
    {
        List<MovimientoDto> GetAll_Dto();
        List<MovimientoDto> GetByParams(int categoria, string inicio, string fin);
    }
}

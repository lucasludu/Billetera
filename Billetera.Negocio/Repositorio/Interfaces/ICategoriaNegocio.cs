using Billetera.Models;
using Billetera.Models.Dto;

namespace Billetera.Negocio.Repositorio.Interfaces
{
    public interface ICategoriaNegocio : IBaseNegocio<Categoria>
    {
        List<CategoriaConsultaDto> GetAll_Dto();
        List<CategoriaConsultaDto> GetByParams(int idTm);
        List<Categoria> GetListByCombo();
    }
}

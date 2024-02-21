using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.Repositorio.Interfaces;
using Billetera.Negocio.UOW;

namespace Billetera.Negocio.Repositorio
{
    public class CategoriaNegocio : BaseNegocio<Categoria>, ICategoriaNegocio
    {
        public List<CategoriaConsultaDto> GetAll_Dto()
        {
            return (from categoria in _context.Categoria
                    join tipoMovimiento in _context.TipoMovimientos 
                        on categoria.IdTipoMovimiento equals tipoMovimiento.Id
                    select new CategoriaConsultaDto { 
                        Id = categoria.Id,
                        Descripcion = categoria.Descripcion!,
                        TipoMovimiento = tipoMovimiento.Tipo!
                    })
                    .ToList();
        }

        public List<CategoriaConsultaDto> GetByParams(int idTm)
        {
            var query = from categ in _context.Categoria 
                        join tm in _context.TipoMovimientos
                            on categ.IdTipoMovimiento equals tm.Id  
                        select new { categ, tm };

            query = idTm == 0 ? query : query.Where(a => a.categ.IdTipoMovimiento == idTm);

            var lista = new List<CategoriaConsultaDto>();

            foreach(var q in query)
            {
                var dto = new CategoriaConsultaDto(q.categ.Id, q.categ.Descripcion, q.tm.Tipo );
                lista.Add(dto);
            }
            return lista;
        }

        public List<Categoria> GetListByCombo()
        {
            var listaCategorias = _context.Categoria.ToList();
            listaCategorias.Add(new Categoria(0, "TODOS"));
            return listaCategorias.OrderBy(a => a.Id).ToList();
        }
    }
}

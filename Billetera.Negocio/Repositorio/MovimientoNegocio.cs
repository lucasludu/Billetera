using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.Repositorio.Interfaces;

namespace Billetera.Negocio.Repositorio
{
    public class MovimientoNegocio : BaseNegocio<Movimiento>, IMovimientoNegocio
    {
        public List<MovimientoDto> GetAll_Dto()
        {
            return (from m in _context.Movimientos
                    join c in _context.Categoria on m.IdCategoria equals c.Id
                    join u in _context.Usuarios on m.IdUsuario equals u.Id
                    select new MovimientoDto
                    {
                        Usuario = $"{u.Apellido}, {u.Nombre}",
                        Monto = (decimal)m.Monto!,
                        Categoria = c.Descripcion!,
                        Descripcion = m.Descripcion!,
                        Fecha = (DateTime)m.Fecha!
                    }).ToList();
        }

        public List<MovimientoDto> GetByParams(int categoria, string inicio, string fin)
        {
            var query = from m in _context.Movimientos
                        join c in _context.Categoria on m.IdCategoria equals c.Id
                        join u in _context.Usuarios on m.IdUsuario equals u.Id
                        select new { m, c, u };

            query = categoria == 0 ? query : query.Where(a => a.m.IdCategoria == categoria);
            query = string.IsNullOrEmpty(inicio) ? query : query.Where(a => a.m.Fecha >= DateTime.Parse(inicio));
            query = string.IsNullOrEmpty(fin) ? query : query.Where(a => a.m.Fecha <= DateTime.Parse(fin));

            var lista = new List<MovimientoDto>();
            foreach (var q in query)
            {
                var dto = new MovimientoDto($"{q.u.Apellido}, {q.u.Nombre}", (decimal)q.m.Monto!, q.c.Descripcion!, q.m.Descripcion!);
                lista.Add(dto);
            }
            return lista;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Billetera.Models
{
    public partial class Movimiento
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
        public virtual TipoMovimiento IdTipoMovimientoNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}

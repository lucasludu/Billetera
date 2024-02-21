using System;
using System.Collections.Generic;

namespace Billetera.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento()
        {
            Categoria = new HashSet<Categoria>();
            Movimientos = new HashSet<Movimiento>();
        }

        public int Id { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}

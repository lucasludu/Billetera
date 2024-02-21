using System;
using System.Collections.Generic;

namespace Billetera.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Gastos = new HashSet<Gasto>();
            Ingresos = new HashSet<Ingreso>();
            Movimientos = new HashSet<Movimiento>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int IdTipoMovimiento { get; set; }

        public virtual TipoMovimiento IdTipoMovimientoNavigation { get; set; } = null!;
        public virtual ICollection<Gasto> Gastos { get; set; }
        public virtual ICollection<Ingreso> Ingresos { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}

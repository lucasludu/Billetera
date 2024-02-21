using System;
using System.Collections.Generic;

namespace Billetera.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Gastos = new HashSet<Gasto>();
            Ingresos = new HashSet<Ingreso>();
            Movimientos = new HashSet<Movimiento>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Edad { get; set; }
        public string Pass { get; set; } = null!;

        public virtual ICollection<Gasto> Gastos { get; set; }
        public virtual ICollection<Ingreso> Ingresos { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}

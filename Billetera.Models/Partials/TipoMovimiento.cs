using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento(int id, string tipo) : base()
        {
            this.Id = id;
            this.Tipo = tipo;
        }
    }
}

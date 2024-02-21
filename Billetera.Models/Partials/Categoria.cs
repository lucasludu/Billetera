using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera.Models
{
    public partial class Categoria
    {
        public Categoria(int id, string descripcion) : base()
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}

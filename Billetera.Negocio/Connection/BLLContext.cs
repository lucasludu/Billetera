using Billetera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera.Negocio.Connection
{
    public class BLLContext : IDisposable
    {
        protected Context _context;


        public BLLContext()
        {
            StringConnection.GetStringConnection();
            this._context = new Context(StringConnection.stringConnection);
        }


        public void Dispose()
        {
            this.Dispose();
        }
    }
}

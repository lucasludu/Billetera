using Billetera.Negocio.Repositorio;
using Billetera.Negocio.Repositorio.Interfaces;

namespace Billetera.Negocio.UOW
{
    public class UnitOfWork : IUnitOfWork
    {


        private ICategoriaNegocio categoria;
        private IMovimientoNegocio movimiento;
        private ITipoMovimientoNegocio tipoMovimiento;
        private IUsuarioNegocio usuario;


        public UnitOfWork()
        {
            
        }




        public ICategoriaNegocio Categoria
        {
            get
            {
                return categoria ?? (categoria = new CategoriaNegocio());
            }
        }

        public IMovimientoNegocio Movimiento
        {
            get
            {
                return movimiento ?? (movimiento = new MovimientoNegocio());
            }        
        }

        public ITipoMovimientoNegocio TipoMovimiento
        {
            get
            {
                return tipoMovimiento ?? (tipoMovimiento = new TipoMovimientoNegocio());
            }
        }

        public IUsuarioNegocio Usuario
        {
            get
            {
                return usuario ?? (usuario = new UsuarioNegocio());
            }
        }

        public void Dispose()
        {
        }
    }
}

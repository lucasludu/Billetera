namespace Billetera.Models.Dto
{
    public class MovimientoRegisterDto
    {
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; } 
        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; }


        public MovimientoRegisterDto()
        {
            this.Fecha = DateTime.UtcNow;
        }

        public MovimientoRegisterDto(int idusuario, int idcategoria, decimal monto, int idTipoMovimiento, string descripcion) : base()
        {
            this.IdUsuario = idusuario;
            this.IdCategoria = idcategoria;
            this.Monto = monto;
            this.Fecha = DateTime.UtcNow;
            this.IdTipoMovimiento = idTipoMovimiento;
            this.Descripcion = descripcion;
        }
    }
}

namespace Billetera.Models.Dto
{
    public class CategoriaDto
    {
        public string Descripcion { get; set; }
        public int IdTipoMovimiento { get; set; }

        public CategoriaDto()
        {
            
        }


        public CategoriaDto(string descripcion, int idtipomovimiento) : base()
        {
            this.Descripcion = descripcion;
            this.IdTipoMovimiento = idtipomovimiento;
        }
    }
}

namespace Billetera.Models.Dto
{
    public class CategoriaConsultaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string TipoMovimiento { get; set; }

        public CategoriaConsultaDto()
        {
            
        }


        public CategoriaConsultaDto(int id, string descripcion, string tipomovimiento) : base()
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.TipoMovimiento = tipomovimiento;
        }
    }
}

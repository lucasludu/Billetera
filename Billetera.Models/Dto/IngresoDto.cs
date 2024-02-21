namespace Billetera.Models.Dto
{
    public class IngresoDto
    {
        public string Usuario { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public IngresoDto()
        {
            
        }

        public IngresoDto(string usuario, decimal monto, string categoria, string descripcion)
        {
            this.Usuario = usuario;
            this.Monto = monto;
            this.Fecha = DateTime.UtcNow;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
        }
    }
}

namespace Billetera.Models.Dto
{
    public class UsuarioDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }

        public UsuarioDto()
        {
            
        }

        public UsuarioDto(string nombre, string apellido, string email, int edad) : base()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Edad = edad;
        }
    }
}

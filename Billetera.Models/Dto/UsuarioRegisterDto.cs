namespace Billetera.Models.Dto
{
    public class UsuarioRegisterDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Pass { get; set; }

        public UsuarioRegisterDto()
        {
            
        }

        public UsuarioRegisterDto(string nombre, string apellido, string email, int edad, string pass) : base()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Edad = edad;
            this.Pass = pass;
        }
    }
}

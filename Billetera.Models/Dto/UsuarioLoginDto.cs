namespace Billetera.Models.Dto
{
    public class UsuarioLoginDto
    {
        public string Email { get; set; }
        public string Pass { get; set; }

        public UsuarioLoginDto()
        {
            
        }

        public UsuarioLoginDto(string email, string pass) : base()
        {
            this.Email = email;
            this.Pass = pass;
        }
    }
}

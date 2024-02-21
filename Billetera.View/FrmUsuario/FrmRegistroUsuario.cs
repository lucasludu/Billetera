using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.Repositorio;
using Billetera.Negocio.UOW;

namespace Billetera.View.FrmUsuario
{
    public partial class FrmRegistroUsuario : FrmBase
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();

            bsUsuario.DataSource = new Usuario();

        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            bsUsuario.DataSource = new Usuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bsUsuario.DataSource = new Usuario();
            txtConfirmPassword.Text = string.Empty;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var uow = new UnitOfWork();
            var repositorio = new UsuarioNegocio();
            var usuario = (Usuario)bsUsuario.Current;

            var dto = _mapper.Map<UsuarioRegisterDto>(usuario);

            try
            {
                if (usuario.Pass.Equals(txtConfirmPassword.Text))
                {
                    if (uow.Usuario.GetByCondition(a => a.Email == dto.Email) == null)
                    {
                        if (uow.Usuario.Insert(_mapper.Map<Usuario>(dto)))
                        {
                            ShowMessage("Ingreso Éxitoso", Color.Blue, 3000);
                        }
                        else
                        {
                            ShowMessage("No se pudo registrar", Color.Red, 3000);
                        }
                    }
                    else
                    {
                        ShowMessage("Usuario existente.", Color.Red, 3000);
                    }
                }
                else
                {
                    ShowMessage("Contraseña Incorrecta", Color.Red, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private async void ShowMessage(string message, Color color, int time)
        {
            txtMessage.ForeColor = color;
            txtMessage.Text = message;
            await Task.Delay(time);
        }

    }
}

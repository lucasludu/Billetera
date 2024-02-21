using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.UOW;
using Billetera.View.FrmMenu;
using Billetera.View.FrmUsuario;

namespace Billetera.View
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bsLogin.DataSource = new UsuarioLoginDto();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bsLogin.DataSource = new UsuarioLoginDto();
        }


        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var uow = new UnitOfWork();
            var login = (UsuarioLoginDto)bsLogin.Current;
            try
            {
                var usuario = uow.Usuario.GetByCondition(a =>
                                                    a.Email!.ToLower().Equals(login.Email.ToLower()) &&
                                                    a.Pass!.Equals(login.Pass));
                if (usuario != null)
                {
                    var frmMenuPrincipal = new FrmMenuPrincipal(_mapper.Map<UsuarioDto>(usuario));
                    //this.btnRefresh_Click(sender, e);
                    frmMenuPrincipal.ShowDialog();
                }
                else
                {
                    txtMessage.ForeColor = Color.Red;
                    txtMessage.Text = $"Usuario y/o contraseña incorrecta";
                    await Task.Delay(3000);
                    txtMessage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var frmRegistroUsuario = new FrmRegistroUsuario();
            frmRegistroUsuario.ShowDialog();
        }

        private void btnOlvidePassword_Click(object sender, EventArgs e)
        {

        }
    }
}

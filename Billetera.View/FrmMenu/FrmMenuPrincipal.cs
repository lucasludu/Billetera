using Billetera.Models.Dto;
using Billetera.View.FrmABM;
using Billetera.View.FrmConsulta;

namespace Billetera.View.FrmMenu
{
    public partial class FrmMenuPrincipal : Form
    {
        public UsuarioDto _usuario { get; set; }

        public FrmMenuPrincipal(UsuarioDto usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            txtNombreUsuario.Text = $"{usuario.Apellido} {usuario.Nombre}";
            txtEmailUsuario.Text = $"{usuario.Email}";
            bsUsuario.DataSource = _usuario;
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCategoriAbm = new FrmCategoriaABM();
            frmCategoriAbm.Show();
        }

        private void movimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmMovimiento = new FrmMovimientoABM(_usuario);
            frmMovimiento.Show();
        }


        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMovimiento = new FrmMovimientoConsulta(_usuario);
            frmMovimiento.Show();
        }
    }
}

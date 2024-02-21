using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.UOW;
using Codigos.Utiles;

namespace Billetera.View.FrmConsulta
{
    public partial class FrmMovimientoConsulta : FrmBase
    {
        public UsuarioDto _usuario { get; set; }

        public FrmMovimientoConsulta(UsuarioDto usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FrmMovimientoConsulta_Load(object sender, EventArgs e)
        {
            bsCategoria.DataSource = new UnitOfWork().Categoria.GetListByCombo();
            bsMovimiento.DataSource = new ExtendedBindingList<MovimientoDto>();
            txtCantidadRegistros.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbCategoria.SelectedIndex = 0;
            txtFechaDesde.Text = string.Empty;
            txtFechaHasta.Text = string.Empty;
            txtCantidadRegistros.Text = string.Empty;
            bsMovimiento.DataSource = new ExtendedBindingList<MovimientoDto>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = (Categoria)bsCategoria.Current;
                var uow = new UnitOfWork();

                if (tbControlMovimiento.SelectedTab == tabPageMovimiento)
                {
                    bsMovimiento.DataSource = new ExtendedBindingList<MovimientoDto>(uow.Movimiento.GetByParams(categoria.Id, txtFechaDesde.Text, txtFechaHasta.Text));
                    txtCantidadRegistros.Text = bsMovimiento.List.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                ShowMessageError(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}

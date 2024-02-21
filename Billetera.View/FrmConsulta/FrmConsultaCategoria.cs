using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.UOW;
using Codigos.Utiles;

namespace Billetera.View.FrmConsulta
{
    public partial class FrmConsultaCategoria : FrmBase
    {
        public FrmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void FrmConsultaCategoria_Load(object sender, EventArgs e)
        {
            bsCategoria.DataSource = new ExtendedBindingList<Categoria>();

            try
            {
                bsTipoMovimiento.DataSource = new UnitOfWork().TipoMovimiento.GetListByCombo();
                txtNroRegistros.Text = bsCategoria.List.Count.ToString();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbTipoMovimiento.SelectedIndex = 0;
            bsCategoria.DataSource = new ExtendedBindingList<Categoria>();
            txtNroRegistros.Text = string.Empty;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var uow = new UnitOfWork();
                var idTm = ((TipoMovimiento)bsTipoMovimiento.Current).Id;
                var lista = uow.Categoria.GetByParams(idTm);

                if (lista.Count > 0)
                {
                    bsCategoria.DataSource = new ExtendedBindingList<CategoriaConsultaDto>(lista);
                    txtNroRegistros.Text = lista.Count.ToString();
                }
                else
                {
                    ShowMessageInfo("No hay una lista cargada.");
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

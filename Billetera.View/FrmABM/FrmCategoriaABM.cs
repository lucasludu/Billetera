using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.UOW;
using Billetera.View.FrmConsulta;

namespace Billetera.View.FrmABM
{
    public partial class FrmCategoriaABM : FrmBase
    {

        public FrmCategoriaABM()
        {
            InitializeComponent();
        }

        private void FrmCategoriaABM_Load(object sender, EventArgs e)
        {
            bsCategoria.DataSource = new CategoriaDto();
            bsTipoMovimiento.DataSource = new UnitOfWork().TipoMovimiento.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bsCategoria.DataSource = new CategoriaDto();
            bsTipoMovimiento.DataSource = new TipoMovimiento();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var uow = new UnitOfWork();
            var categoriaDto = (CategoriaDto)bsCategoria.Current;
            var tipoMovimiento = (TipoMovimiento)bsTipoMovimiento.Current;
            try
            {
                if (uow.Categoria.GetByCondition(a => a.Descripcion!.ToLower().Trim().Equals(categoriaDto.Descripcion.ToLower().Trim())) == null)
                {
                    categoriaDto.IdTipoMovimiento = tipoMovimiento.Id;
                    if (uow.Categoria.Insert(_mapper.Map<Categoria>(categoriaDto)))
                    {
                        ShowMessage("Ingreso Éxitoso", Color.Blue, 3000);
                    }
                    else
                    {
                        ShowMessage("No se pudo insertar", Color.Red, 3000);
                    }
                }
                else
                {
                    ShowMessage("Ya existe la categoria ingresada", Color.Red, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultaCategoria_Click(object sender, EventArgs e)
        {
            var frmConsultaCategoria = new FrmConsultaCategoria();
            frmConsultaCategoria.Show();
        }




        private async void ShowMessage(string message, Color color, int time)
        {
            txtMessage.ForeColor = color;
            txtMessage.Text = message;
            await Task.Delay(time);
        }

    }
}

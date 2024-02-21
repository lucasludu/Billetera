using Billetera.Models;
using Billetera.Models.Dto;
using Billetera.Negocio.UOW;
using Billetera.View.FrmConsulta;

namespace Billetera.View.FrmABM
{
    public partial class FrmMovimientoABM : FrmBase
    {
        public UsuarioDto _usuario { get; set; }

        public FrmMovimientoABM(UsuarioDto usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FrmMovimientoABM_Load(object sender, EventArgs e)
        {
            try
            {
                var uow = new UnitOfWork();
                bsMovimiento.DataSource = new MovimientoRegisterDto();
                bsTipoMovimiento.DataSource = uow.TipoMovimiento.GetAll();
                bsCategoria.DataSource = uow.Categoria.GetAllByCondition(a => a.IdTipoMovimiento == ((TipoMovimiento)bsTipoMovimiento.Current).Id);
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
            bsTipoMovimiento.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var movimiento = (MovimientoRegisterDto)bsMovimiento.Current;
                var tipoMov = (TipoMovimiento)bsTipoMovimiento.Current;
                var categoria = (Categoria)bsCategoria.Current;
                var uow = new UnitOfWork();
                var usuario = uow.Usuario.GetByCondition(a => a.Email.Equals(_usuario.Email));


                var insert = new MovimientoRegisterDto(usuario.Id, categoria.Id, (decimal)movimiento.Monto!, tipoMov.Id, movimiento.Descripcion);

                if (uow.Movimiento.Insert(_mapper.Map<Movimiento>(insert)))
                {
                    ShowMessage("Se agregó con éxito", Color.Blue, 3000);
                }
                else
                {
                    ShowMessage("No se pudo insertar correctamente", Color.Red, 3000);
                }
            }
            catch (Exception ex)
            {
                ShowMessageError(ex.Message);
            }
        }

        private void btnConsultaMovimiento_Click(object sender, EventArgs e)
        {
            var frmConsultaMovimiento = new FrmMovimientoConsulta(_usuario);
            frmConsultaMovimiento.ShowDialog();
        }

        private void cmbTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tm = (TipoMovimiento)cmbTipoMovimiento.SelectedItem;

            try
            {
                var uow = new UnitOfWork();

                var listaCategoria = uow.Categoria.GetAllByCondition(a => a.IdTipoMovimiento == tm.Id);
                bsCategoria.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {
                ShowMessageError(ex.Message);
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

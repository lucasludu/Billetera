namespace Billetera.View.FrmABM
{
    partial class FrmMovimientoABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientoABM));
            gbxAccion = new GroupBox();
            btnConsultaMovimiento = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            btnRefresh = new Button();
            gbxDatos = new GroupBox();
            txtDescripcion = new TextBox();
            bsMovimiento = new BindingSource(components);
            label1 = new Label();
            cmbCategoria = new ComboBox();
            bsCategoria = new BindingSource(components);
            cmbTipoMovimiento = new ComboBox();
            bsTipoMovimiento = new BindingSource(components);
            txtMonto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            txtMessage = new ToolStripStatusLabel();
            gbxAccion.SuspendLayout();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsMovimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAccion
            // 
            gbxAccion.Controls.Add(btnConsultaMovimiento);
            gbxAccion.Controls.Add(btnSalir);
            gbxAccion.Controls.Add(btnAgregar);
            gbxAccion.Controls.Add(btnRefresh);
            gbxAccion.Location = new Point(12, 12);
            gbxAccion.Name = "gbxAccion";
            gbxAccion.Size = new Size(408, 82);
            gbxAccion.TabIndex = 1;
            gbxAccion.TabStop = false;
            // 
            // btnConsultaMovimiento
            // 
            btnConsultaMovimiento.BackColor = Color.LightGray;
            btnConsultaMovimiento.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaMovimiento.Image = (Image)resources.GetObject("btnConsultaMovimiento.Image");
            btnConsultaMovimiento.Location = new Point(12, 26);
            btnConsultaMovimiento.Name = "btnConsultaMovimiento";
            btnConsultaMovimiento.Size = new Size(40, 40);
            btnConsultaMovimiento.TabIndex = 18;
            btnConsultaMovimiento.UseVisualStyleBackColor = false;
            btnConsultaMovimiento.Click += btnConsultaMovimiento_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(362, 26);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 17;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightGray;
            btnAgregar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(270, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(40, 40);
            btnAgregar.TabIndex = 15;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(316, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 16;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(txtDescripcion);
            gbxDatos.Controls.Add(label1);
            gbxDatos.Controls.Add(cmbCategoria);
            gbxDatos.Controls.Add(cmbTipoMovimiento);
            gbxDatos.Controls.Add(txtMonto);
            gbxDatos.Controls.Add(label4);
            gbxDatos.Controls.Add(label3);
            gbxDatos.Controls.Add(label2);
            gbxDatos.Location = new Point(12, 100);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(408, 178);
            gbxDatos.TabIndex = 2;
            gbxDatos.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.DataBindings.Add(new Binding("Text", bsMovimiento, "Descripcion", true));
            txtDescripcion.Location = new Point(159, 130);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 27);
            txtDescripcion.TabIndex = 28;
            // 
            // bsMovimiento
            // 
            bsMovimiento.DataSource = typeof(Models.Dto.MovimientoRegisterDto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 133);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 27;
            label1.Text = "Descripcion: ";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DataSource = bsCategoria;
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(159, 63);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(237, 28);
            cmbCategoria.TabIndex = 26;
            cmbCategoria.ValueMember = "Id";
            // 
            // bsCategoria
            // 
            bsCategoria.DataSource = typeof(Models.Categoria);
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.DataSource = bsTipoMovimiento;
            cmbTipoMovimiento.DisplayMember = "Tipo";
            cmbTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Location = new Point(159, 29);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(237, 28);
            cmbTipoMovimiento.TabIndex = 25;
            cmbTipoMovimiento.ValueMember = "Id";
            cmbTipoMovimiento.SelectedIndexChanged += cmbTipoMovimiento_SelectedIndexChanged;
            // 
            // bsTipoMovimiento
            // 
            bsTipoMovimiento.DataSource = typeof(Models.TipoMovimiento);
            // 
            // txtMonto
            // 
            txtMonto.DataBindings.Add(new Binding("Text", bsMovimiento, "Monto", true));
            txtMonto.Location = new Point(159, 97);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(237, 27);
            txtMonto.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 22;
            label4.Text = "Tipo de Movimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 21;
            label3.Text = "Monto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 20;
            label2.Text = "Categoria:";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtMessage });
            statusStrip1.Location = new Point(0, 281);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(432, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(0, 16);
            // 
            // FrmMovimientoABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(statusStrip1);
            Controls.Add(gbxDatos);
            Controls.Add(gbxAccion);
            Name = "FrmMovimientoABM";
            Text = "FrmMovimientoABM";
            Load += FrmMovimientoABM_Load;
            gbxAccion.ResumeLayout(false);
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsMovimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxAccion;
        private Button btnConsultaMovimiento;
        private Button btnSalir;
        private Button btnAgregar;
        private Button btnRefresh;
        private GroupBox gbxDatos;
        private Label label3;
        private Label label2;
        private TextBox txtMonto;
        private Label label4;
        private ComboBox cmbTipoMovimiento;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtMessage;
        private BindingSource bsMovimiento;
        private BindingSource bsTipoMovimiento;
        private BindingSource bsCategoria;
        private ComboBox cmbCategoria;
        private TextBox txtDescripcion;
        private Label label1;
    }
}
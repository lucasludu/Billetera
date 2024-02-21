namespace Billetera.View.FrmConsulta
{
    partial class FrmMovimientoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientoConsulta));
            gbxFiltro = new GroupBox();
            btnBuscar = new Button();
            gbxRangoFecha = new GroupBox();
            txtFechaDesde = new TextBox();
            txtFechaHasta = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            bsCategoria = new BindingSource(components);
            label1 = new Label();
            gbxDatos = new GroupBox();
            btnExcel = new Button();
            btnSalir = new Button();
            btnRefresh = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtCantidadRegistros = new ToolStripStatusLabel();
            tbControlMovimiento = new TabControl();
            tabPageMovimiento = new TabPage();
            dgvMovimiento = new DataGridView();
            categoriaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            montoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bsMovimiento = new BindingSource(components);
            gbxFiltro.SuspendLayout();
            gbxRangoFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).BeginInit();
            gbxDatos.SuspendLayout();
            statusStrip1.SuspendLayout();
            tbControlMovimiento.SuspendLayout();
            tabPageMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMovimiento).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltro
            // 
            gbxFiltro.Controls.Add(btnBuscar);
            gbxFiltro.Controls.Add(gbxRangoFecha);
            gbxFiltro.Controls.Add(cmbCategoria);
            gbxFiltro.Controls.Add(label1);
            gbxFiltro.Location = new Point(12, 12);
            gbxFiltro.Name = "gbxFiltro";
            gbxFiltro.Size = new Size(512, 115);
            gbxFiltro.TabIndex = 7;
            gbxFiltro.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(466, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 40);
            btnBuscar.TabIndex = 22;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gbxRangoFecha
            // 
            gbxRangoFecha.Controls.Add(txtFechaDesde);
            gbxRangoFecha.Controls.Add(txtFechaHasta);
            gbxRangoFecha.Controls.Add(label3);
            gbxRangoFecha.Controls.Add(label2);
            gbxRangoFecha.Location = new Point(175, 26);
            gbxRangoFecha.Name = "gbxRangoFecha";
            gbxRangoFecha.Size = new Size(285, 83);
            gbxRangoFecha.TabIndex = 12;
            gbxRangoFecha.TabStop = false;
            gbxRangoFecha.Text = "Rango de Fecha";
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.Location = new Point(6, 48);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(125, 27);
            txtFechaDesde.TabIndex = 6;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.Location = new Point(137, 48);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(125, 27);
            txtFechaHasta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 25);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 11;
            label3.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 9;
            label2.Text = "Desde";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DataSource = bsCategoria;
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(6, 69);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 7;
            cmbCategoria.ValueMember = "Id";
            // 
            // bsCategoria
            // 
            bsCategoria.DataSource = typeof(Models.Categoria);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 6;
            label1.Text = "Categoria";
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(btnExcel);
            gbxDatos.Controls.Add(btnSalir);
            gbxDatos.Controls.Add(btnRefresh);
            gbxDatos.Location = new Point(530, 12);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(258, 115);
            gbxDatos.TabIndex = 6;
            gbxDatos.TabStop = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LightGray;
            btnExcel.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.Location = new Point(6, 46);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(40, 40);
            btnExcel.TabIndex = 20;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(212, 46);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 19;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(166, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 18;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtCantidadRegistros });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 24;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(170, 20);
            toolStripStatusLabel1.Text = "Cantidad de Registros: ";
            // 
            // txtCantidadRegistros
            // 
            txtCantidadRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidadRegistros.ForeColor = SystemColors.HotTrack;
            txtCantidadRegistros.Name = "txtCantidadRegistros";
            txtCantidadRegistros.Size = new Size(0, 20);
            // 
            // tbControlMovimiento
            // 
            tbControlMovimiento.Controls.Add(tabPageMovimiento);
            tbControlMovimiento.Location = new Point(12, 133);
            tbControlMovimiento.Name = "tbControlMovimiento";
            tbControlMovimiento.SelectedIndex = 0;
            tbControlMovimiento.Size = new Size(776, 292);
            tbControlMovimiento.TabIndex = 25;
            // 
            // tabPageMovimiento
            // 
            tabPageMovimiento.Controls.Add(dgvMovimiento);
            tabPageMovimiento.Location = new Point(4, 29);
            tabPageMovimiento.Name = "tabPageMovimiento";
            tabPageMovimiento.Padding = new Padding(3);
            tabPageMovimiento.Size = new Size(768, 259);
            tabPageMovimiento.TabIndex = 0;
            tabPageMovimiento.Text = "Movimiento";
            tabPageMovimiento.UseVisualStyleBackColor = true;
            // 
            // dgvMovimiento
            // 
            dgvMovimiento.AllowUserToAddRows = false;
            dgvMovimiento.AllowUserToDeleteRows = false;
            dgvMovimiento.AutoGenerateColumns = false;
            dgvMovimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimiento.Columns.AddRange(new DataGridViewColumn[] { categoriaDataGridViewTextBoxColumn1, descripcionDataGridViewTextBoxColumn1, montoDataGridViewTextBoxColumn1, fechaDataGridViewTextBoxColumn1 });
            dgvMovimiento.DataSource = bsMovimiento;
            dgvMovimiento.Location = new Point(6, 6);
            dgvMovimiento.Name = "dgvMovimiento";
            dgvMovimiento.ReadOnly = true;
            dgvMovimiento.RowHeadersVisible = false;
            dgvMovimiento.RowHeadersWidth = 51;
            dgvMovimiento.RowTemplate.Height = 29;
            dgvMovimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimiento.Size = new Size(756, 247);
            dgvMovimiento.TabIndex = 0;
            // 
            // categoriaDataGridViewTextBoxColumn1
            // 
            categoriaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoriaDataGridViewTextBoxColumn1.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn1.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            categoriaDataGridViewTextBoxColumn1.Name = "categoriaDataGridViewTextBoxColumn1";
            categoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            descripcionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn1
            // 
            montoDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            montoDataGridViewTextBoxColumn1.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn1.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            montoDataGridViewTextBoxColumn1.Name = "montoDataGridViewTextBoxColumn1";
            montoDataGridViewTextBoxColumn1.ReadOnly = true;
            montoDataGridViewTextBoxColumn1.Width = 82;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            fechaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsMovimiento
            // 
            bsMovimiento.DataSource = typeof(Models.Dto.MovimientoDto);
            // 
            // FrmMovimientoConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbControlMovimiento);
            Controls.Add(statusStrip1);
            Controls.Add(gbxFiltro);
            Controls.Add(gbxDatos);
            Name = "FrmMovimientoConsulta";
            Text = "FrmMovimientoConsulta";
            Load += FrmMovimientoConsulta_Load;
            gbxFiltro.ResumeLayout(false);
            gbxFiltro.PerformLayout();
            gbxRangoFecha.ResumeLayout(false);
            gbxRangoFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).EndInit();
            gbxDatos.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tbControlMovimiento.ResumeLayout(false);
            tabPageMovimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMovimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbxFiltro;
        private Button btnBuscar;
        private GroupBox gbxRangoFecha;
        private TextBox txtFechaDesde;
        private TextBox txtFechaHasta;
        private Label label3;
        private Label label2;
        private ComboBox cmbCategoria;
        private Label label1;
        private GroupBox gbxDatos;
        private Button btnExcel;
        private Button btnSalir;
        private Button btnRefresh;
        private StatusStrip statusStrip1;
        private TabControl tbControlMovimiento;
        private TabPage tabPageMovimiento;
        private DataGridView dgvMovimiento;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtCantidadRegistros;
        private BindingSource bsCategoria;
        private BindingSource bsMovimiento;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
    }
}
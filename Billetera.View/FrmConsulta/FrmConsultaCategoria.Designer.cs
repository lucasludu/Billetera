namespace Billetera.View.FrmConsulta
{
    partial class FrmConsultaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCategoria));
            dgvCategoria = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMovimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsCategoria = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtNroRegistros = new ToolStripStatusLabel();
            gbxDatos = new GroupBox();
            btnExcel = new Button();
            btnSalir = new Button();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            cmbTipoMovimiento = new ComboBox();
            bsTipoMovimiento = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).BeginInit();
            statusStrip1.SuspendLayout();
            gbxDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, tipoMovimientoDataGridViewTextBoxColumn });
            dgvCategoria.DataSource = bsCategoria;
            dgvCategoria.Location = new Point(12, 104);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.RowTemplate.Height = 29;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(558, 270);
            dgvCategoria.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 51;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMovimientoDataGridViewTextBoxColumn
            // 
            tipoMovimientoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento";
            tipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento";
            tipoMovimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoMovimientoDataGridViewTextBoxColumn.Name = "tipoMovimientoDataGridViewTextBoxColumn";
            tipoMovimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCategoria
            // 
            bsCategoria.DataSource = typeof(Models.Dto.CategoriaConsultaDto);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtNroRegistros });
            statusStrip1.Location = new Point(0, 377);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(582, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(170, 20);
            toolStripStatusLabel1.Text = "Cantidad de Registros: ";
            // 
            // txtNroRegistros
            // 
            txtNroRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroRegistros.ForeColor = SystemColors.HotTrack;
            txtNroRegistros.Name = "txtNroRegistros";
            txtNroRegistros.Size = new Size(0, 20);
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(btnExcel);
            gbxDatos.Controls.Add(btnSalir);
            gbxDatos.Controls.Add(btnRefresh);
            gbxDatos.Location = new Point(369, 12);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(201, 86);
            gbxDatos.TabIndex = 2;
            gbxDatos.TabStop = false;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcel.BackColor = Color.LightGray;
            btnExcel.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.Location = new Point(6, 26);
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
            btnSalir.Location = new Point(149, 26);
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
            btnRefresh.Location = new Point(103, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 18;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cmbTipoMovimiento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 86);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(305, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 40);
            btnBuscar.TabIndex = 21;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.DataSource = bsTipoMovimiento;
            cmbTipoMovimiento.DisplayMember = "Tipo";
            cmbTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Location = new Point(6, 45);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(258, 28);
            cmbTipoMovimiento.TabIndex = 1;
            cmbTipoMovimiento.ValueMember = "Id";
            // 
            // bsTipoMovimiento
            // 
            bsTipoMovimiento.DataSource = typeof(Models.TipoMovimiento);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(217, 19);
            label1.TabIndex = 0;
            label1.Text = "Filtrar por Tipo de Movimiento";
            // 
            // FrmConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(groupBox1);
            Controls.Add(gbxDatos);
            Controls.Add(statusStrip1);
            Controls.Add(dgvCategoria);
            MaximumSize = new Size(600, 450);
            MinimumSize = new Size(600, 450);
            Name = "FrmConsultaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            Load += FrmConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gbxDatos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private StatusStrip statusStrip1;
        private BindingSource bsCategoria;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMovimientoDataGridViewTextBoxColumn;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtNroRegistros;
        private GroupBox gbxDatos;
        private Button btnSalir;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private Button btnExcel;
        private ComboBox cmbTipoMovimiento;
        private Label label1;
        private Button btnBuscar;
        private BindingSource bsTipoMovimiento;
    }
}
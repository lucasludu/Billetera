namespace Billetera.View.FrmABM
{
    partial class FrmCategoriaABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaABM));
            groupBox1 = new GroupBox();
            btnConsultaCategoria = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            btnRefresh = new Button();
            groupBox2 = new GroupBox();
            cmbTipoMovimiento = new ComboBox();
            bsTipoMovimiento = new BindingSource(components);
            txtDescripcion = new TextBox();
            bsCategoria = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            stMessage = new StatusStrip();
            txtMessage = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).BeginInit();
            stMessage.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultaCategoria);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnConsultaCategoria
            // 
            btnConsultaCategoria.BackColor = Color.LightGray;
            btnConsultaCategoria.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaCategoria.Image = (Image)resources.GetObject("btnConsultaCategoria.Image");
            btnConsultaCategoria.Location = new Point(12, 26);
            btnConsultaCategoria.Name = "btnConsultaCategoria";
            btnConsultaCategoria.Size = new Size(40, 40);
            btnConsultaCategoria.TabIndex = 18;
            btnConsultaCategoria.UseVisualStyleBackColor = false;
            btnConsultaCategoria.Click += btnConsultaCategoria_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(341, 26);
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
            btnAgregar.Location = new Point(249, 26);
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
            btnRefresh.Location = new Point(295, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 16;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbTipoMovimiento);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.DataSource = bsTipoMovimiento;
            cmbTipoMovimiento.DisplayMember = "Tipo";
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Location = new Point(169, 58);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(212, 28);
            cmbTipoMovimiento.TabIndex = 3;
            cmbTipoMovimiento.ValueMember = "Id";
            // 
            // bsTipoMovimiento
            // 
            bsTipoMovimiento.DataSource = typeof(Models.TipoMovimiento);
            // 
            // txtDescripcion
            // 
            txtDescripcion.DataBindings.Add(new Binding("Text", bsCategoria, "Descripcion", true));
            txtDescripcion.Location = new Point(169, 26);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // bsCategoria
            // 
            bsCategoria.DataSource = typeof(Models.Dto.CategoriaDto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Movimiento: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Descripción: ";
            // 
            // stMessage
            // 
            stMessage.ImageScalingSize = new Size(20, 20);
            stMessage.Items.AddRange(new ToolStripItem[] { txtMessage });
            stMessage.Location = new Point(0, 231);
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(412, 22);
            stMessage.TabIndex = 2;
            stMessage.Text = "statusStrip1";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.ForeColor = SystemColors.HotTrack;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(0, 16);
            // 
            // FrmCategoriaABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 253);
            Controls.Add(stMessage);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(430, 300);
            MinimumSize = new Size(430, 300);
            Name = "FrmCategoriaABM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria ABM";
            Load += FrmCategoriaABM_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsTipoMovimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCategoria).EndInit();
            stMessage.ResumeLayout(false);
            stMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox cmbTipoMovimiento;
        private TextBox txtDescripcion;
        private Button btnSalir;
        private Button btnAgregar;
        private Button btnRefresh;
        private BindingSource bsCategoria;
        private BindingSource bsTipoMovimiento;
        private Button btnConsultaCategoria;
        private StatusStrip stMessage;
        private ToolStripStatusLabel txtMessage;
    }
}
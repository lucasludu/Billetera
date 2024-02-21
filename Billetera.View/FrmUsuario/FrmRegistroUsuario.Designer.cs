namespace Billetera.View.FrmUsuario
{
    partial class FrmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            bsUsuario = new BindingSource(components);
            txtConfirmPassword = new TextBox();
            txtEdad = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnRegistrarse = new Button();
            btnRefresh = new Button();
            btnSalir = new Button();
            gbxDatos = new GroupBox();
            gbxAccion = new GroupBox();
            stMessage = new StatusStrip();
            txtMessage = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)bsUsuario).BeginInit();
            gbxDatos.SuspendLayout();
            gbxAccion.SuspendLayout();
            stMessage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Edad: ";
            // 
            // txtNombre
            // 
            txtNombre.DataBindings.Add(new Binding("Text", bsUsuario, "Nombre", true));
            txtNombre.Location = new Point(139, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 4;
            // 
            // bsUsuario
            // 
            bsUsuario.DataSource = typeof(Models.Usuario);
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(139, 185);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.DataBindings.Add(new Binding("Text", bsUsuario, "Edad", true));
            txtEdad.Location = new Point(139, 86);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(250, 27);
            txtEdad.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bsUsuario, "Email", true));
            txtEmail.Location = new Point(139, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.DataBindings.Add(new Binding("Text", bsUsuario, "Apellido", true));
            txtApellido.Location = new Point(139, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.DataBindings.Add(new Binding("Text", bsUsuario, "Pass", true));
            txtPassword.Location = new Point(139, 152);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 155);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 188);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 11;
            label6.Text = "Confirm Password";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.LightGray;
            btnRegistrarse.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.Image = (Image)resources.GetObject("btnRegistrarse.Image");
            btnRegistrarse.Location = new Point(12, 26);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(40, 40);
            btnRegistrarse.TabIndex = 12;
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(58, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 13;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(366, 26);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 14;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(label1);
            gbxDatos.Controls.Add(label2);
            gbxDatos.Controls.Add(label3);
            gbxDatos.Controls.Add(label4);
            gbxDatos.Controls.Add(label6);
            gbxDatos.Controls.Add(txtNombre);
            gbxDatos.Controls.Add(label5);
            gbxDatos.Controls.Add(txtConfirmPassword);
            gbxDatos.Controls.Add(txtPassword);
            gbxDatos.Controls.Add(txtEdad);
            gbxDatos.Controls.Add(txtApellido);
            gbxDatos.Controls.Add(txtEmail);
            gbxDatos.Location = new Point(12, 90);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(412, 242);
            gbxDatos.TabIndex = 15;
            gbxDatos.TabStop = false;
            // 
            // gbxAccion
            // 
            gbxAccion.Controls.Add(btnSalir);
            gbxAccion.Controls.Add(btnRegistrarse);
            gbxAccion.Controls.Add(btnRefresh);
            gbxAccion.Location = new Point(12, 12);
            gbxAccion.Name = "gbxAccion";
            gbxAccion.Size = new Size(412, 72);
            gbxAccion.TabIndex = 16;
            gbxAccion.TabStop = false;
            // 
            // stMessage
            // 
            stMessage.ImageScalingSize = new Size(20, 20);
            stMessage.Items.AddRange(new ToolStripItem[] { txtMessage });
            stMessage.Location = new Point(0, 333);
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(442, 24);
            stMessage.TabIndex = 17;
            stMessage.Text = "statusStrip1";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.ForeColor = SystemColors.HotTrack;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(0, 18);
            // 
            // FrmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 357);
            Controls.Add(stMessage);
            Controls.Add(gbxAccion);
            Controls.Add(gbxDatos);
            Name = "FrmRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuario";
            Load += FrmRegistroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)bsUsuario).EndInit();
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            gbxAccion.ResumeLayout(false);
            stMessage.ResumeLayout(false);
            stMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtConfirmPassword;
        private TextBox txtEdad;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtPassword;
        private Label label5;
        private Label label6;
        private Button btnRegistrarse;
        private Button btnRefresh;
        private Button btnSalir;
        private GroupBox gbxDatos;
        private GroupBox gbxAccion;
        private BindingSource bsUsuario;
        private StatusStrip stMessage;
        private ToolStripStatusLabel txtMessage;
    }
}
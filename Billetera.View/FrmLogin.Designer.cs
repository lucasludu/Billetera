namespace Billetera.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            bsLogin = new BindingSource(components);
            txtPassword = new TextBox();
            gbxUsuario = new GroupBox();
            btnOlvidePassword = new Button();
            btnSalir = new Button();
            btnRefresh = new Button();
            gbxAccion = new GroupBox();
            btnRegistrarse = new Button();
            stMessage = new StatusStrip();
            txtMessage = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)bsLogin).BeginInit();
            gbxUsuario.SuspendLayout();
            gbxAccion.SuspendLayout();
            stMessage.SuspendLayout();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LightGray;
            btnIngresar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.Location = new Point(12, 229);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(165, 70);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bsLogin, "Email", true));
            txtEmail.Location = new Point(95, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 27);
            txtEmail.TabIndex = 3;
            // 
            // bsLogin
            // 
            bsLogin.DataSource = typeof(Models.Dto.UsuarioLoginDto);
            // 
            // txtPassword
            // 
            txtPassword.DataBindings.Add(new Binding("Text", bsLogin, "Pass", true));
            txtPassword.Location = new Point(95, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(357, 27);
            txtPassword.TabIndex = 4;
            // 
            // gbxUsuario
            // 
            gbxUsuario.Controls.Add(label1);
            gbxUsuario.Controls.Add(txtPassword);
            gbxUsuario.Controls.Add(label2);
            gbxUsuario.Controls.Add(txtEmail);
            gbxUsuario.Location = new Point(12, 98);
            gbxUsuario.Name = "gbxUsuario";
            gbxUsuario.Size = new Size(458, 125);
            gbxUsuario.TabIndex = 5;
            gbxUsuario.TabStop = false;
            // 
            // btnOlvidePassword
            // 
            btnOlvidePassword.BackColor = SystemColors.Control;
            btnOlvidePassword.FlatAppearance.BorderColor = Color.White;
            btnOlvidePassword.FlatAppearance.BorderSize = 0;
            btnOlvidePassword.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOlvidePassword.ForeColor = SystemColors.HotTrack;
            btnOlvidePassword.Location = new Point(183, 229);
            btnOlvidePassword.Name = "btnOlvidePassword";
            btnOlvidePassword.Size = new Size(287, 32);
            btnOlvidePassword.TabIndex = 5;
            btnOlvidePassword.Text = "Olvide la contraseña";
            btnOlvidePassword.TextAlign = ContentAlignment.MiddleLeft;
            btnOlvidePassword.UseVisualStyleBackColor = false;
            btnOlvidePassword.Click += btnOlvidePassword_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(412, 26);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 16;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(366, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 15;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gbxAccion
            // 
            gbxAccion.Controls.Add(btnRefresh);
            gbxAccion.Controls.Add(btnSalir);
            gbxAccion.Location = new Point(12, 12);
            gbxAccion.Name = "gbxAccion";
            gbxAccion.Size = new Size(458, 80);
            gbxAccion.TabIndex = 17;
            gbxAccion.TabStop = false;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.Control;
            btnRegistrarse.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = SystemColors.HotTrack;
            btnRegistrarse.Location = new Point(183, 267);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(287, 32);
            btnRegistrarse.TabIndex = 18;
            btnRegistrarse.Text = "Ingrese aquí para registrarse";
            btnRegistrarse.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // stMessage
            // 
            stMessage.ImageScalingSize = new Size(20, 20);
            stMessage.Items.AddRange(new ToolStripItem[] { txtMessage });
            stMessage.Location = new Point(0, 309);
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(482, 24);
            stMessage.TabIndex = 19;
            stMessage.Text = "statusStrip1";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.ForeColor = SystemColors.HotTrack;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(0, 18);
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 333);
            Controls.Add(stMessage);
            Controls.Add(btnRegistrarse);
            Controls.Add(gbxAccion);
            Controls.Add(btnOlvidePassword);
            Controls.Add(gbxUsuario);
            Controls.Add(btnIngresar);
            MaximumSize = new Size(500, 380);
            MinimumSize = new Size(500, 380);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)bsLogin).EndInit();
            gbxUsuario.ResumeLayout(false);
            gbxUsuario.PerformLayout();
            gbxAccion.ResumeLayout(false);
            stMessage.ResumeLayout(false);
            stMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private GroupBox gbxUsuario;
        private Button btnOlvidePassword;
        private BindingSource bsLogin;
        private Button btnSalir;
        private Button btnRefresh;
        private GroupBox gbxAccion;
        private Button btnRegistrarse;
        private StatusStrip stMessage;
        private ToolStripStatusLabel txtMessage;
    }
}
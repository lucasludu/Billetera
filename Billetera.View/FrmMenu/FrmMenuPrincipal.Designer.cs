namespace Billetera.View.FrmMenu
{
    partial class FrmMenuPrincipal
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
            menuPrincipal = new MenuStrip();
            menuVer = new ToolStripMenuItem();
            cuentasAPagarToolStripMenuItem = new ToolStripMenuItem();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            ingresosToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            perfilDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuAgregar = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            movimientoToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtNombreUsuario = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            txtEmailUsuario = new ToolStripStatusLabel();
            bsUsuario = new BindingSource(components);
            menuPrincipal.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsUsuario).BeginInit();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuVer, menuAgregar });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 28);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // menuVer
            // 
            menuVer.DropDownItems.AddRange(new ToolStripItem[] { cuentasAPagarToolStripMenuItem, gastosToolStripMenuItem, ingresosToolStripMenuItem, movimientosToolStripMenuItem, perfilDeUsuarioToolStripMenuItem });
            menuVer.Name = "menuVer";
            menuVer.Size = new Size(44, 24);
            menuVer.Text = "Ver";
            // 
            // cuentasAPagarToolStripMenuItem
            // 
            cuentasAPagarToolStripMenuItem.Name = "cuentasAPagarToolStripMenuItem";
            cuentasAPagarToolStripMenuItem.Size = new Size(224, 26);
            cuentasAPagarToolStripMenuItem.Text = "Cuentas a pagar";
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(224, 26);
            gastosToolStripMenuItem.Text = "Gastos";
            // 
            // ingresosToolStripMenuItem
            // 
            ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            ingresosToolStripMenuItem.Size = new Size(224, 26);
            ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(224, 26);
            movimientosToolStripMenuItem.Text = "Movimientos";
            movimientosToolStripMenuItem.Click += movimientosToolStripMenuItem_Click;
            // 
            // perfilDeUsuarioToolStripMenuItem
            // 
            perfilDeUsuarioToolStripMenuItem.Name = "perfilDeUsuarioToolStripMenuItem";
            perfilDeUsuarioToolStripMenuItem.Size = new Size(224, 26);
            perfilDeUsuarioToolStripMenuItem.Text = "Perfil de Usuario";
            // 
            // menuAgregar
            // 
            menuAgregar.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, movimientoToolStripMenuItem1 });
            menuAgregar.Name = "menuAgregar";
            menuAgregar.Size = new Size(77, 24);
            menuAgregar.Text = "Agregar";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(172, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // movimientoToolStripMenuItem1
            // 
            movimientoToolStripMenuItem1.Name = "movimientoToolStripMenuItem1";
            movimientoToolStripMenuItem1.Size = new Size(172, 26);
            movimientoToolStripMenuItem1.Text = "Movimiento";
            movimientoToolStripMenuItem1.Click += movimientoToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtNombreUsuario, toolStripStatusLabel2, txtEmailUsuario });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(71, 20);
            toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.ForeColor = SystemColors.HotTrack;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(18, 20);
            txtNombreUsuario.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(64, 20);
            toolStripStatusLabel2.Text = "Correo: ";
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.ForeColor = SystemColors.HotTrack;
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(18, 20);
            txtEmailUsuario.Text = "...";
            // 
            // bsUsuario
            // 
            bsUsuario.DataSource = typeof(Models.Dto.UsuarioDto);
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuVer;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem ingresosToolStripMenuItem;
        private ToolStripMenuItem cuentasAPagarToolStripMenuItem;
        private ToolStripMenuItem perfilDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem menuAgregar;
        private ToolStripMenuItem movimientoToolStripMenuItem1;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtNombreUsuario;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel txtEmailUsuario;
        private BindingSource bsUsuario;
    }
}
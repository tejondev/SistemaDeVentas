namespace CapaPresentacion
{
    partial class FrmInicio
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.mnMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.mnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.mnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.mnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.mnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.mnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.mnAcerdaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUsuarios,
            this.mnMantenedor,
            this.mnVentas,
            this.mnCompras,
            this.mnClientes,
            this.mnProveedores,
            this.mnReportes,
            this.mnAcerdaDe});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 54);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(982, 78);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.mnUsuarios.IconColor = System.Drawing.Color.Black;
            this.mnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnUsuarios.IconSize = 50;
            this.mnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Size = new System.Drawing.Size(79, 74);
            this.mnUsuarios.Text = "Usuarios";
            this.mnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnMantenedor
            // 
            this.mnMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.mnMantenedor.IconColor = System.Drawing.Color.Black;
            this.mnMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnMantenedor.IconSize = 50;
            this.mnMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMantenedor.Name = "mnMantenedor";
            this.mnMantenedor.Size = new System.Drawing.Size(104, 74);
            this.mnMantenedor.Text = "Mantenedor";
            this.mnMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnVentas
            // 
            this.mnVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.mnVentas.IconColor = System.Drawing.Color.Black;
            this.mnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnVentas.IconSize = 50;
            this.mnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnVentas.Name = "mnVentas";
            this.mnVentas.Size = new System.Drawing.Size(66, 74);
            this.mnVentas.Text = "Ventas";
            this.mnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnCompras
            // 
            this.mnCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.mnCompras.IconColor = System.Drawing.Color.Black;
            this.mnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnCompras.IconSize = 50;
            this.mnCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnCompras.Name = "mnCompras";
            this.mnCompras.Size = new System.Drawing.Size(82, 74);
            this.mnCompras.Text = "Compras";
            this.mnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnClientes
            // 
            this.mnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.mnClientes.IconColor = System.Drawing.Color.Black;
            this.mnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnClientes.IconSize = 50;
            this.mnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnClientes.Name = "mnClientes";
            this.mnClientes.Size = new System.Drawing.Size(75, 74);
            this.mnClientes.Text = "Clientes";
            this.mnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnProveedores
            // 
            this.mnProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.mnProveedores.IconColor = System.Drawing.Color.Black;
            this.mnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnProveedores.IconSize = 50;
            this.mnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProveedores.Name = "mnProveedores";
            this.mnProveedores.Size = new System.Drawing.Size(105, 74);
            this.mnProveedores.Text = "Proveedores";
            this.mnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnReportes
            // 
            this.mnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.mnReportes.IconColor = System.Drawing.Color.Black;
            this.mnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnReportes.IconSize = 50;
            this.mnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnReportes.Name = "mnReportes";
            this.mnReportes.Size = new System.Drawing.Size(82, 74);
            this.mnReportes.Text = "Reportes";
            this.mnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnAcerdaDe
            // 
            this.mnAcerdaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.mnAcerdaDe.IconColor = System.Drawing.Color.Black;
            this.mnAcerdaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnAcerdaDe.IconSize = 50;
            this.mnAcerdaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnAcerdaDe.Name = "mnAcerdaDe";
            this.mnAcerdaDe.Size = new System.Drawing.Size(89, 74);
            this.mnAcerdaDe.Text = "Acerca de";
            this.mnAcerdaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(982, 54);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 132);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(982, 421);
            this.pnlContenedor.TabIndex = 3;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmInicio";
            this.Text = "frmInicio";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private FontAwesome.Sharp.IconMenuItem mnProveedores;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem mnUsuarios;
        private FontAwesome.Sharp.IconMenuItem mnMantenedor;
        private FontAwesome.Sharp.IconMenuItem mnVentas;
        private FontAwesome.Sharp.IconMenuItem mnCompras;
        private FontAwesome.Sharp.IconMenuItem mnClientes;
        private FontAwesome.Sharp.IconMenuItem mnReportes;
        private FontAwesome.Sharp.IconMenuItem mnAcerdaDe;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}
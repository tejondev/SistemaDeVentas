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
            this.subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.mnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.mnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.mnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.mnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.mnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.mnAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDetalleVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDetalleCompras = new FontAwesome.Sharp.IconMenuItem();
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
            this.mnAcercaDe});
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
            this.mnUsuarios.Click += new System.EventHandler(this.mnUsuarios_Click);
            // 
            // mnMantenedor
            // 
            this.mnMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategorias,
            this.subMenuProductos});
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
            // subMenuCategorias
            // 
            this.subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategorias.IconColor = System.Drawing.Color.Black;
            this.subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategorias.Name = "subMenuCategorias";
            this.subMenuCategorias.Size = new System.Drawing.Size(224, 26);
            this.subMenuCategorias.Text = "Categorías";
            this.subMenuCategorias.Click += new System.EventHandler(this.subMenuCategorias_Click);
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(224, 26);
            this.subMenuProductos.Text = "Productos";
            this.subMenuProductos.Click += new System.EventHandler(this.subMenuProductos_Click);
            // 
            // mnVentas
            // 
            this.mnVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuDetalleVentas});
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
            this.mnCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuDetalleCompras});
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
            this.mnClientes.Click += new System.EventHandler(this.mnClientes_Click);
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
            this.mnProveedores.Click += new System.EventHandler(this.mnProveedores_Click);
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
            this.mnReportes.Click += new System.EventHandler(this.mnReportes_Click);
            // 
            // mnAcercaDe
            // 
            this.mnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.mnAcercaDe.IconColor = System.Drawing.Color.Black;
            this.mnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnAcercaDe.IconSize = 50;
            this.mnAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnAcercaDe.Name = "mnAcercaDe";
            this.mnAcercaDe.Size = new System.Drawing.Size(89, 74);
            this.mnAcercaDe.Text = "Acerca de";
            this.mnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.pnlContenedor.Size = new System.Drawing.Size(982, 521);
            this.pnlContenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(769, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(852, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(224, 26);
            this.subMenuRegistrarVenta.Text = "Nueva Venta";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuDetalleVentas
            // 
            this.subMenuDetalleVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDetalleVentas.IconColor = System.Drawing.Color.Black;
            this.subMenuDetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDetalleVentas.Name = "subMenuDetalleVentas";
            this.subMenuDetalleVentas.Size = new System.Drawing.Size(224, 26);
            this.subMenuDetalleVentas.Text = "Ver Detalles";
            this.subMenuDetalleVentas.Click += new System.EventHandler(this.subMenuDetalleVentas_Click);
            // 
            // subMenuRegistrarCompra
            // 
            this.subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(224, 26);
            this.subMenuRegistrarCompra.Text = "Nueva Compra";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuDetalleCompras
            // 
            this.subMenuDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDetalleCompras.IconColor = System.Drawing.Color.Black;
            this.subMenuDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDetalleCompras.Name = "subMenuDetalleCompras";
            this.subMenuDetalleCompras.Size = new System.Drawing.Size(224, 26);
            this.subMenuDetalleCompras.Text = "Detalle Compras";
            this.subMenuDetalleCompras.Click += new System.EventHandler(this.subMenuDetalleCompras_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
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
        private FontAwesome.Sharp.IconMenuItem mnAcercaDe;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem subMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuProductos;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuDetalleVentas;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuDetalleCompras;
    }
}
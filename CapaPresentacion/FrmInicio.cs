using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo;

        public FrmInicio(Usuario objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            // RESTRINGIR VISTAS =============================================================
            List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenuItem in menuPrincipal.Items)
            {
                // m es cada elemento de la lista
                bool encontrado = listaPermisos.Any(m => m.NombreMenu == iconMenuItem.Name);

                if(encontrado == false) iconMenuItem.Visible = false;
            }



            // Nombre de usuario en pantalla principal
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }

        // Recibe el menu o submenu donde se dio clic
        // Tambien el Formulario que se desea abrir
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Colores en el menu
            if(menuActivo != null) menuActivo.BackColor = Color.White;
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            // Preconfigurar formulario
            if (formularioActivo != null) formularioActivo.Close();
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            // Agregar formulario al pnlContenedor
            pnlContenedor.Controls.Add(formularioActivo);
            formulario.Show();
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmUsuarios());
        }

        // 
        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            // Al ser submenu, no se envia el sender, sino el Menu Principal
            AbrirFormulario(mnMantenedor, new FrmCategoria());
        }

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnMantenedor, new FrmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnVentas, new FrmVentas());
        }

        private void subMenuDetalleVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnVentas, new FrmDetalleVentas());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnCompras, new FrmCompras());
        }

        private void subMenuDetalleCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnCompras, new FrmDetalleCompras());
        }

        private void mnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmClientes());
        }

        private void mnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmProveedores());
        }

        private void mnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmReportes());
        }
    }
}

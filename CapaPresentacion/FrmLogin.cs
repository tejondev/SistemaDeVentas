using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Conectar con CapaNegocio =======================================================
            //List<Usuario> TEST = new CN_Usuario().Listar();  
            
            // El primero o null (con expresiones lambda)
            Usuario usuario = new CN_Usuario()
                .Listar()
                .Where(u => u.Documento == txtUsuario.Text && u.Clave == txtContrasenia.Text)
                .FirstOrDefault() ;


            if(usuario != null)
            {
                // Abrir siguiente formulario ====================================================
                FrmInicio form = new FrmInicio();
                form.Show();

                // Ocultar login
                this.Hide();

                // Al cerrar la nueva ventana, volver a abrir el login
                form.FormClosing += Frm_Closing;
            } else
            {
                MessageBox.Show("No se encontró al usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Mostrar el form de login al cerrar programa principal
        private void Frm_Closing(object sender, FormClosingEventArgs e) {

            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            this.Show();
        }
    }
}

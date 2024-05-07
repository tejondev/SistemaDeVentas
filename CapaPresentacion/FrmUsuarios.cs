using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // Llenar comboBox de estado
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 0, Texto = "Inactivo" });
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 1, Texto = "Activo"});
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            // Llenar comboBox de roles
            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol rolItem in listaRol)
            {
                cmbRol.Items.Add(new OpcionComboBox() { Valor = rolItem.IdRol, Texto = rolItem.Descripcion });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;

            // Llenar comboBox de filtro
            foreach(DataGridViewColumn columna in dgvData.Columns)
            {
                if(columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cmbBusqueda.Items.Add(new OpcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] {
                "", 
                txtId.Text, 
                txtDocumento.Text, 
                txtNombreCompleto.Text, 
                txtCorreo.Text, 
                txtContrasenia.Text, 
                ((OpcionComboBox)cmbRol.SelectedItem).Valor.ToString(), 
                ((OpcionComboBox)cmbRol.SelectedItem).Texto.ToString(),
                ((OpcionComboBox)cmbEstado.SelectedItem).Valor.ToString(),
                ((OpcionComboBox)cmbEstado.SelectedItem).Texto.ToString()
            });

            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";
            cmbRol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }
    }

}

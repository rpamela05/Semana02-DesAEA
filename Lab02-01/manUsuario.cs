using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string fec_nac = dtpNacimiento.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            dataGridView1.Rows.Add(dni, nombre, telefono, direccion, fec_nac, apellido, email);
        }
    }
}

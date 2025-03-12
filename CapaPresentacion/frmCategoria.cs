using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        private bool IsEditar=false;
        private bool IsNuevo = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void Habilitar()
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbEstado.Enabled = true;
            dtFecha.Enabled = true;
        }

        private void DesHabilitar()
        {
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbEstado.Enabled = false;
            dtFecha.Enabled = false;
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cmbEstado.Text = string.Empty;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataListadoCategoria_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataListadoCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

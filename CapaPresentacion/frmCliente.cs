using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  //Paquete para conetarnos con SQL Server

namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void ComprobarConexion()
        {
            string conexion = "Data Source=10PUC31A1201PC0\\SQLEXPRESS;Initial Catalog=hotelDB;Integrated Security=True";

            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                try
                {
                    conectar.Open();
                    MessageBox.Show("Conectado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ComprobarConexion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal: Form
    {
        private frmCliente cliente = null; //Se crea la variable privada cliente que almacena al objeto frmCliente para ser instanciada posteriormente
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            producto.ShowDialog();
        }

        private void toolClientes_Click(object sender, EventArgs e)
        {
            //Verificar si el formulario hijo es null o ha sido cerrado (disposed)
            if (cliente == null || cliente.IsDisposed)
            {
                cliente = new frmCliente(); // Crear una nueva instancia si está cerrado
                cliente.Show(); //// Mostrar el formulario
            }
            else
            {
                cliente.Activate(); // Si ya está abierto, traerlo al frente
            }
        }

        private void menuCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void toolReservas_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.ShowDialog();
        }

        // Método para comprobar la conexión
        private void ComprobarConexion()
        {
            // Cadena de conexión (ajústala a tu configuración)
            string cadenaConexion = "Data Source=DESKTOP-PNL0DF6\\SQLEXPRESS;Initial Catalog=hotelDB;Integrated Security=True";

            // Intentamos abrir una conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // Intentar abrir la conexión
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, mostramos el mensaje de error
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void toolPago_Click(object sender, EventArgs e)
        {
            this.ComprobarConexion();  
        }
    }
}

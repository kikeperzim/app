using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSplash: Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000; // Tiempo de duración en milisegundos (3 segundos)
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMascota
{
    public partial class VentasGatos : Form
    {
        private List<venta> Mascotas = new List<venta>();
        public VentasGatos()
        {
            InitializeComponent();
            
        }

        private void ventaDeGatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvventagato_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView Mascotas = new ListView();
            
        }
    }
}

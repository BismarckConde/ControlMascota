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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btngato_Click(object sender, EventArgs e)
        {
            VENTAS_DE_PERROS ventaperros = new VENTAS_DE_PERROS();
           ventaperros.ShowDialog();

        }

        private void btnperro_Click(object sender, EventArgs e)
        {
            VentasGatos ventagatos = new VentasGatos();
            ventagatos.ShowDialog();
        }
    }
}

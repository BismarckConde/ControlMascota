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
    public partial class VENTAS_DE_PERROS : Form
    {
        public VENTAS_DE_PERROS()
        {
            InitializeComponent();
        }

        private void lvventagato_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
        }

        private void btnagregar_Click(object sender, EventArgs e, VENTAS_DE_PERROS obj)
        {
            ListView perro = new ListView();
            perro.Items.Add(txtnombreperro.Text);
            perro.Items.Add(txtcolorperro.Text);
            perro.Items.Add(txtedadperro.Text);
            perro.Items.Add(txtcostoperro.Text);

            lvventagato.Items.Add(perro);
        }
    }
}

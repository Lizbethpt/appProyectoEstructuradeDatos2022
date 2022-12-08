using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyectoEstructuradeDatos2022
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnEstructuras_Click(object sender, EventArgs e)
        {
            Form estructuras = new FrmEstructuras();
            estructuras.Show();
        }

        private void BtnOrdenamientos_Click(object sender, EventArgs e)
        {
            Form ordenamientos = new FrmOrdenamientos();
            ordenamientos.Show();
        }
    }
}

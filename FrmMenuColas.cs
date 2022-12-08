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
    public partial class FrmMenuColas : Form
    {
        public FrmMenuColas()
        {
            InitializeComponent();
        }

        private void BtnBicola_Click(object sender, EventArgs e)
        {
            Form bicola = new FrmBicola();
            bicola.Show();
        }

        private void BtnColaCircular_Click(object sender, EventArgs e)
        {
            Form colacircular = new FrmColaCircularDinamica();
            colacircular.Show();
        }

        private void BtnColaDinamica_Click(object sender, EventArgs e)
        {
            Form dinamica = new Colalistaenlazada();
            dinamica.Show();
        }

        private void BtnColadeprioridad_Click(object sender, EventArgs e)
        {
            Form prioridad = new FrmColaPrioridad();
            prioridad.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

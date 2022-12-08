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
    public partial class FrmEstructuras : Form
    {
        public FrmEstructuras()
        {
            InitializeComponent();
        }

        private void PBListasdoblesE_Click(object sender, EventArgs e)
        {
            Form listasdoblese = new FrmListasdoblesenlazadas();
            listasdoblese.Show();
        }
        private void PBListasSimplesE_Click(object sender, EventArgs e)
        {
            Form listassimples = new FrmListasSimples();
            listassimples.Show();
        }
        private void PBListasSimplesCirculares_Click(object sender, EventArgs e)
        {
            Form circulares = new FrmListaCircular();
            circulares.Show();
        }
        private void PBListasDoblesCirculares_Click(object sender, EventArgs e)
        {
            Form doblecircular = new FrmListadoblecircular();
            doblecircular.Show();
        }
        private void PBColas_Click(object sender, EventArgs e)
        {
            Form cola = new FrmMenuColas();
            cola.Show();
        }

        private void PBGrafos_Click(object sender, EventArgs e)
        {
            Form grafos = new FrmGrafos();
            grafos.Show();
        }

        private void PBArbol_Click(object sender, EventArgs e)
        {
            Form arbol = new FrmArbolcs();
            arbol.Show();
        }
    }
}

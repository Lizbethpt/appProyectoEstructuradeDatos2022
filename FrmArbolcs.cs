using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appProyectoEstructuradeDatos2022
{
    public partial class FrmArbolcs : Form
    {
        ABB arbol;
        public FrmArbolcs()
        {
            InitializeComponent();
            arbol = new ABB();
        }
        private void Txt()
        {
            tbInorden.Text = arbol.Inorden();
            tbPreorden.Text = arbol.Preorden();
            tbPostorden.Text = arbol.Postorden();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            arbol.limpiar();
            string ruta = arbol.Graficar();
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tbInsertar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInorden_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPreorden_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPostorden_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Insertar(tbInsertar.Text);
                Txt();
                string ruta = arbol.Graficar();
                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
            tbInsertar.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Eliminar(tbInsertar.Text);
                Txt();
                string ruta = arbol.Graficar();
                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
            tbInsertar.Clear();
        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            arbol.limpiar();
            Txt();
            string ruta = arbol.Graficar();
            System.Threading.Thread.Sleep(1000);
            FileStream file = new FileStream(ruta, FileMode.Open);
            Image img = Image.FromStream(file);
            pictureBox1.Image = img;
            file.Close();
            tbInsertar.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

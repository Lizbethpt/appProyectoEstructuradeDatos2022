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
    public partial class Colalistaenlazada : Form
    {
        public Colalistaenlazada()
        {
            InitializeComponent();
        }
        Colalista colaDinamica = new Colalista();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            colaDinamica.Agregar(txtDato.Text);
            txtCola.Text = colaDinamica.ToString();
            txtDato.Clear();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            colaDinamica.Eliminar();
            txtCola.Text = colaDinamica.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


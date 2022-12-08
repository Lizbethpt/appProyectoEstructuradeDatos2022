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
    public partial class FrmColaCircularDinamica : Form
    {
        public FrmColaCircularDinamica()
        {
            InitializeComponent();
        }
        Cola circular = new Cola();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            circular.Agregar(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = circular.ToString();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            circular.Eliminar();
            txtCola.Text = circular.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

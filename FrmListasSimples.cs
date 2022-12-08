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
    public partial class FrmListasSimples : Form
    {
        public FrmListasSimples()
        {
            InitializeComponent();
        }
        NodoListaSimple n;
        OperacionesListaSimple MiLista = new OperacionesListaSimple();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            n = new NodoListaSimple();
            n.Dato = int.Parse(txtNodo.Text);
            MiLista.Agregar(n);
            lblLista.Text = MiLista.ToString();
            txtNodo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtNodo.Text);
            MiLista.Borrar(dato);
            lblLista.Text = MiLista.ToString();
            txtNodo.Clear();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

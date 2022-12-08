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
    public partial class FrmListaCircular : Form
    {
        NodoListaCirular n;
        private ListaCircular MiLista;
        public FrmListaCircular()
        {
            InitializeComponent();
            MiLista = new ListaCircular();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                MiLista = new ListaCircular();
            }
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoListaCirular();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
        private void BtnEliminarNodo_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                return;
            }
            try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("Dato no encontrado");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MiLista.Borrar(dato);
                lblLista.Text = MiLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }
        private void BtnContar_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                return;
            }
            MessageBox.Show("Número de nodos en la lista:" + MiLista.ContarNodos());
        }
        private void BtnVaciarLista_Click(object sender, EventArgs e)
        {
            MiLista = null;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

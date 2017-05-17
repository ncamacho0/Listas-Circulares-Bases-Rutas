using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Base miBase;
        Ruta ruta = new Ruta();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            int minutos = int.Parse(txtMinutos.Text);
            miBase = new Base(nombre, minutos);
            ruta.agregar(miBase);
            txtNombre.Text = "";
            txtMinutos.Text = "";
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int minutos = int.Parse(txtMinutos.Text);
            miBase = new Base(nombre, minutos);
            ruta.agregarInicio(miBase);
            txtNombre.Text = "";
            txtMinutos.Text = "";
            txtBuscarPorNombre.Text = "";
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {

            Base buscar = ruta.buscar(txtNombre.Text);
            if (buscar == null)
                txtBuscarPorNombre.Text = "Base No encontrada";
            else
                txtBuscarPorNombre.Text = buscar.ToString();
            txtNombre.Text = "";
            txtMinutos.Text = "";
        }

        private void btnEliminarNombre_Click(object sender, EventArgs e)
        {
            ruta.eliminar(txtNombre.Text);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtRecorrer.Text = "";
            txtReporte.Text = ruta.reporte();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            ruta.eliminarInicio();
        }

        private void btnInsertarDespuesDe_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int minutos = int.Parse(txtMinutos.Text);
            string dondeInsertar = txtInsertar.Text;
            miBase = new Base(nombre, minutos);
            ruta.insertar(dondeInsertar, miBase);
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreRecorrer.Text;
            DateTime inicio = Convert.ToDateTime(txtHoraInicioRecorrer.Text), fin = Convert.ToDateTime(txtHoraFinRecorrer.Text);
            txtRecorrer.Text = ruta.recorrido(nombre, inicio, fin);

        }
    }
}

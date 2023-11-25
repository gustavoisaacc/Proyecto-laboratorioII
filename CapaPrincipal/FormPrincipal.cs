using CapaNegocio;
using CapaPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDato;


namespace ProyectoFinalLabo2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }
        private void msNuevoProducto_Click(object sender, EventArgs e)
        {
            FormCarga nuevoProducto = new FormCarga();
            nuevoProducto.ShowDialog();
            cargaDgv();
        }

        private void msNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FormEmpleado formEmpleado = new FormEmpleado();
            formEmpleado.ShowDialog();
        }

        private void msRealizarVenta_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.ShowDialog();
        }

        private void msSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cargaDgv()
        {

            NegocioProducto negocio = new NegocioProducto();

            dgvLista.DataSource = negocio.Listar();

            dgvLista.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.Columns["Vencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvLista.Columns["id"].Visible = false;

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargaDgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Producto seleccionado;
            //FormCarga nuevoProducto = new FormCarga(seleccionado);
            //nuevoProducto.ShowDialog();
        }
    }
}

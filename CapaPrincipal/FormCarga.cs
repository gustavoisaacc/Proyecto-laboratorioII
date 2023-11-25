using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDato;
using System.Collections.Generic;

namespace ProyectoFinalLabo2
{
    public partial class FormCarga : Form
    {
       
        public FormCarga()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCodigo.Text) &&
                string.IsNullOrEmpty(txtPrecio.Text) &&
                string.IsNullOrEmpty(txtCantidad.Text)))
            { 
                if(
                    System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "^[0-9]") &&
                    System.Text.RegularExpressions.Regex.IsMatch(txtCodigo.Text, "^[0-9]") &&
                    System.Text.RegularExpressions.Regex.IsMatch(txtPrecio.Text, "^[0-9]")
                  )
                {
                    Producto producto = new Producto();

                    NegocioProducto negocioProducto = new NegocioProducto();



                    producto.Precio = Convert.ToInt32(txtPrecio.Text);
                    producto.Marca = (Marca)cmbMarca.SelectedItem;
                    producto.Tipo = (Tipo)cmbTipo.SelectedItem;
                    producto.Vencimiento = dtpVence.Value.ToString("dd/mm//yyyy");
                    producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);

                    // MessageBox.Show(producto.Vencimiento + producto.Marca.ToString() + producto.Tipo.ToString());

                    negocioProducto.cargarProducto(producto);
                    MessageBox.Show("El dato fue ingresado con exito!", "Dato Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                }
                else
                {
                    MessageBox.Show("Los datos ingresados deben ser Numeros", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            negocioMarca negocioMarca = new negocioMarca();
            negocioTipo negocioTipo = new negocioTipo();

            cmbMarca.DataSource = negocioMarca.Listar();
            cmbTipo.DataSource = negocioTipo.Listar();

        }
    }
}

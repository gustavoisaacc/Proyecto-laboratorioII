using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDato;
using System.Collections.Generic;

namespace ProyectoFinalLabo2
{
    public partial class FormCarga : Form
    {
        Producto producto = null;
       
        public FormCarga()
        {
            InitializeComponent();
        }
        public FormCarga(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
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
                   NegocioProducto negocioProducto = new NegocioProducto();

                    try
                    {
                        if(producto == null) 
                            producto = new Producto();

                        producto.Precio = Convert.ToInt32(txtPrecio.Text);
                        producto.Marca = (Marca)cmbMarca.SelectedItem;
                        producto.Tipo = (Tipo)cmbTipo.SelectedItem;
                        producto.Vencimiento = dtpVence.Value.ToString("dd/MMM/yyyy");
                        producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        producto.Codigo = Convert.ToInt32(txtCodigo.Text);

                        // MessageBox.Show(producto.Vencimiento + producto.Marca.ToString() + producto.Tipo.ToString());

                        if( producto.Id != 0)
                        {
                            negocioProducto.modificarProducto(producto);
                            MessageBox.Show("El Producto fue modificado con exito!", "Dato Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            negocioProducto.cargarProducto(producto);
                            MessageBox.Show("El Producto fue ingresado con exito!", "Dato Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error {ex.Message}");
                    }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormCarga_Load(object sender, EventArgs e)
        {
            negocioMarca negocioMarca = new negocioMarca();
            negocioTipo negocioTipo = new negocioTipo();

            cmbMarca.DataSource = negocioMarca.Listar();
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Nombre";
            cmbTipo.DataSource = negocioTipo.Listar();
            cmbTipo.ValueMember = "Id";
            cmbTipo.DisplayMember = "Nombre";

            if (producto != null)
            {
                lblTitle.Text = "Editar Producto";
                txtCantidad.Text = producto.Cantidad.ToString();
                txtCodigo.Text = producto.Codigo.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                dtpVence.Text = producto.Vencimiento.ToString();
                cmbMarca.SelectedValue = producto.Marca.Id;
                cmbTipo.SelectedValue = producto.Tipo.Id;
            }

        }
        
    }
}

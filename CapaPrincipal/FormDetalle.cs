using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLabo2
{
    public partial class FormDetalle : Form
    {
        public FormDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString("d");
        }
    }
}

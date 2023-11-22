namespace ProyectoFinalLabo2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblPancho = new System.Windows.Forms.Label();
            this.lblDistri = new System.Windows.Forms.Label();
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNuevoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.msNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.msRealizarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.msSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.msOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(0, 144);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(682, 284);
            this.dgvLista.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(571, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(291, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(252, 26);
            this.txtBuscar.TabIndex = 4;
            // 
            // lblPancho
            // 
            this.lblPancho.AutoSize = true;
            this.lblPancho.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPancho.ForeColor = System.Drawing.Color.Transparent;
            this.lblPancho.Location = new System.Drawing.Point(48, 73);
            this.lblPancho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPancho.Name = "lblPancho";
            this.lblPancho.Size = new System.Drawing.Size(142, 46);
            this.lblPancho.TabIndex = 12;
            this.lblPancho.Text = "Pancho";
            // 
            // lblDistri
            // 
            this.lblDistri.AutoSize = true;
            this.lblDistri.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistri.ForeColor = System.Drawing.Color.Transparent;
            this.lblDistri.Location = new System.Drawing.Point(40, 44);
            this.lblDistri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistri.Name = "lblDistri";
            this.lblDistri.Size = new System.Drawing.Size(162, 34);
            this.lblDistri.TabIndex = 11;
            this.lblDistri.Text = "Distribuidora";
            // 
            // msOpciones
            // 
            this.msOpciones.BackColor = System.Drawing.Color.CadetBlue;
            this.msOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.msRealizarVenta,
            this.msSalir});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msOpciones.Size = new System.Drawing.Size(682, 24);
            this.msOpciones.TabIndex = 15;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNuevoEmpleado,
            this.msNuevoProducto});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // msNuevoEmpleado
            // 
            this.msNuevoEmpleado.Name = "msNuevoEmpleado";
            this.msNuevoEmpleado.Size = new System.Drawing.Size(165, 22);
            this.msNuevoEmpleado.Text = "Nuevo Empleado";
            this.msNuevoEmpleado.Click += new System.EventHandler(this.msNuevoEmpleado_Click);
            // 
            // msNuevoProducto
            // 
            this.msNuevoProducto.Name = "msNuevoProducto";
            this.msNuevoProducto.Size = new System.Drawing.Size(165, 22);
            this.msNuevoProducto.Text = "Nuevo Producto";
            this.msNuevoProducto.Click += new System.EventHandler(this.msNuevoProducto_Click);
            // 
            // msRealizarVenta
            // 
            this.msRealizarVenta.Name = "msRealizarVenta";
            this.msRealizarVenta.Size = new System.Drawing.Size(91, 20);
            this.msRealizarVenta.Text = "Realizar Venta";
            this.msRealizarVenta.Click += new System.EventHandler(this.msRealizarVenta_Click);
            // 
            // msSalir
            // 
            this.msSalir.Name = "msSalir";
            this.msSalir.Size = new System.Drawing.Size(41, 20);
            this.msSalir.Text = "Salir";
            this.msSalir.Click += new System.EventHandler(this.msSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(571, 452);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 42);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(467, 452);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(682, 505);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.msOpciones);
            this.Controls.Add(this.lblPancho);
            this.Controls.Add(this.lblDistri);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(698, 544);
            this.MinimumSize = new System.Drawing.Size(698, 544);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblPancho;
        private System.Windows.Forms.Label lblDistri;
        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msNuevoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem msNuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem msRealizarVenta;
        private System.Windows.Forms.ToolStripMenuItem msSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}


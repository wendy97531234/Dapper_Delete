namespace EliminarClienteconDapper
{
    partial class Form1
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
            this.dgvEliminarCliente = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btntBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarCliente
            // 
            this.dgvEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarCliente.Location = new System.Drawing.Point(29, 96);
            this.dgvEliminarCliente.Name = "dgvEliminarCliente";
            this.dgvEliminarCliente.Size = new System.Drawing.Size(491, 256);
            this.dgvEliminarCliente.TabIndex = 0;
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(29, 358);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(251, 23);
            this.btnObtenerTodo.TabIndex = 1;
            this.btnObtenerTodo.Text = "ObtenerTodo";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar ID:";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(89, 407);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(185, 20);
            this.txbBuscar.TabIndex = 3;
            // 
            // btntBuscar
            // 
            this.btntBuscar.Location = new System.Drawing.Point(280, 404);
            this.btntBuscar.Name = "btntBuscar";
            this.btntBuscar.Size = new System.Drawing.Size(91, 23);
            this.btntBuscar.TabIndex = 4;
            this.btntBuscar.Text = "Buscar";
            this.btntBuscar.UseVisualStyleBackColor = true;
            this.btntBuscar.Click += new System.EventHandler(this.btntBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(593, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(593, 117);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(198, 20);
            this.txbId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id_Producto";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(593, 143);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(198, 20);
            this.txbNombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " Nombre";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(593, 169);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(198, 20);
            this.txbDescripcion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(593, 195);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(198, 20);
            this.txbPrecio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio";
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(593, 221);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(198, 20);
            this.txbStock.TabIndex = 15;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(526, 224);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 13);
            this.Label.TabIndex = 14;
            this.Label.Text = "Stock";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(593, 247);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(198, 20);
            this.txbMarca.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Marca";
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(593, 273);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(198, 20);
            this.txbCategoria.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Eliminar cliente con Dapper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.dgvEliminarCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarCliente;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btntBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}


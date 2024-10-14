using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliminarClienteconDapper
{
    public partial class Form1 : Form
    {
        ProductoRepository productoR = new ProductoRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btntBuscar_Click(object sender, EventArgs e)
        {
            var cliente = productoR.ObtenerPorId(Int32.Parse(txbBuscar.Text));
            dgvEliminarCliente.DataSource = new List<Producto> { cliente };

            if (cliente != null)
            {
                RellenarForm(cliente);
            }
        }
        private void RellenarForm(Producto producto)
        {
            txbId.Text = producto.Id.ToString();
            txbNombre.Text = producto.Nombre;
            txbDescripcion.Text = producto.Descripcion;
            txbPrecio.Text = producto.Precio.ToString();
            txbStock.Text = producto.Stock.ToString();
            txbMarca.Text = producto.Marca;
            txbCategoria.Text = producto.Categoria;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var DeleteProduct = productoR.EliminarProducto(Int32.Parse(txbId.Text));
            var productos = productoR.ObtenerTodo();
            dgvEliminarCliente.DataSource = productos;
            MessageBox.Show($"{DeleteProduct} filas modificadas");
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var Producto = productoR.ObtenerTodo();
            dgvEliminarCliente.DataSource = Producto;
        }
    }
}

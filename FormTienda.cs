using EcommercePOO.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommercePOO
{
    public partial class FormTienda : Form
    {
        List<Producto> inventario = new List<Producto>();
        Carrito carrito = new Carrito();
        public FormTienda()
        {
            InitializeComponent();
            CargarProductos();
            MostrarProductos();
            
        }
        private void CargarProductos()
        {
            inventario.Add(new ProductoDigital(1, "Curso C#", "Curso completo", 50, 10, "MP4", 500));
            inventario.Add(new ProductoFisico(2, "Mouse Gamer", "RGB", 30, 20, 0.5, "10x5"));
            inventario.Add(new ProductoFisico(3, "Teclado Mecánico", "Switch Blue", 80, 15, 1.2, "40x15"));
        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = inventario;
        }
        private void MostrarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito.Productos;
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                carrito.AgregarProducto(producto);

                MostrarCarrito();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                Producto producto = (Producto)dgvCarrito.CurrentRow.DataBoundItem;

                carrito.RemoverProducto(producto.Id);

                MostrarCarrito();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total = carrito.CalcularTotal();

            lblTotal.Text = "Total: $" + total;
        }
    }
}

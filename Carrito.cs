using System.Collections.Generic;
using System.Linq;

namespace EcommercePOO.Modelos
{
    public class Carrito
    {
        public List<Producto> Productos { get; set; }

        public Carrito()
        {
            Productos = new List<Producto>();
        }

        // Sobrecarga 1
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        // Sobrecarga 2
        public void AgregarProducto(string nombre, double precio)
        {
            Producto nuevo = new Producto(0, nombre, "", precio, 1);
            Productos.Add(nuevo);
        }

        // Sobrecarga 3
        public void AgregarProducto(int id, List<Producto> inventario)
        {
            Producto p = inventario.FirstOrDefault(x => x.Id == id);
            if (p != null)
                Productos.Add(p);
        }

        public void RemoverProducto(int id)
        {
            Productos.RemoveAll(p => p.Id == id);
        }

        public double CalcularTotal()
        {
            return Productos.Sum(p => p.Precio);
        }
    }
}
using System.Linq;

namespace EcommercePOO.Modelos
{
    public class InventarioDigital : GestorInventario
    {
        public override void AñadirProducto(Producto producto)
        {
            if (producto is ProductoDigital)
            {
                productos.Add(producto);
            }
        }

        public override void EliminarProducto(int id)
        {
            productos.RemoveAll(p => p.Id == id);
        }

        public override void ActualizarStock(int id, int nuevoStock)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto != null)
            {
                producto.Stock = nuevoStock;
            }
        }
    }
}
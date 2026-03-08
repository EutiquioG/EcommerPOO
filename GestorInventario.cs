using System.Collections.Generic;
using EcommercePOO.Interfaces;

namespace EcommercePOO.Modelos
{
    public abstract class GestorInventario : IGestorInventario
    {
        protected List<Producto> productos = new List<Producto>();

        public abstract void AñadirProducto(Producto producto);

        public abstract void EliminarProducto(int id);

        public abstract void ActualizarStock(int id, int stock);

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
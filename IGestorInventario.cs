using EcommercePOO.Modelos;
using System.Collections.Generic;

namespace EcommercePOO.Interfaces
{
    public interface IGestorInventario
    {
        void AñadirProducto(Producto producto);

        void EliminarProducto(int id);

        void ActualizarStock(int id, int stock);

        List<Producto> ObtenerProductos();
    }
}
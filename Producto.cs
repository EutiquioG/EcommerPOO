using System;

namespace EcommercePOO.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Producto(int id, string nombre, string descripcion, double precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        // Método virtual para sobrescribir
        public virtual string MostrarDetalle()
        {
            return $"Producto: {Nombre} - Precio: {Precio}";
        }
    }
}
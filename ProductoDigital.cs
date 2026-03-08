using System;

namespace EcommercePOO.Modelos
{
    public class ProductoDigital : Producto
    {
        public string FormatoArchivo { get; set; }
        public double TamañoMB { get; set; }

        public ProductoDigital(int id, string nombre, string descripcion,
            double precio, int stock, string formato, double tamaño)
            : base(id, nombre, descripcion, precio, stock)
        {
            FormatoArchivo = formato;
            TamañoMB = tamaño;
        }

        // Sobreescritura
        public override string MostrarDetalle()
        {
            return $"Producto Digital: {Nombre} - {FormatoArchivo} - {TamañoMB}MB - Precio: {Precio}";
        }
    }
}
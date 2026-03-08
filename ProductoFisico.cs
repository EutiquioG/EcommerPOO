using System;

namespace EcommercePOO.Modelos
{
    public class ProductoFisico : Producto
    {
        public double Peso { get; set; }
        public string Dimensiones { get; set; }

        public ProductoFisico(int id, string nombre, string descripcion,
            double precio, int stock, double peso, string dimensiones)
            : base(id, nombre, descripcion, precio, stock)
        {
            Peso = peso;
            Dimensiones = dimensiones;
        }

        public override string MostrarDetalle()
        {
            return $"Producto Físico: {Nombre} - Peso: {Peso}kg - Precio: {Precio}";
        }
    }
}
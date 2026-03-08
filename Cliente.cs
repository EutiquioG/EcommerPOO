using System.Collections.Generic;

namespace EcommercePOO.Modelos
{
    public class Cliente : Usuario
    {
        public List<string> HistorialCompras { get; set; }

        public Cliente(int id, string nombre, string correo, string contraseña)
            : base(id, nombre, correo, contraseña)
        {
            HistorialCompras = new List<string>();
        }

        public void AgregarCompra(string compra)
        {
            HistorialCompras.Add(compra);
        }
    }
}
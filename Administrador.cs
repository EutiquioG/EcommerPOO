using System.Collections.Generic;

namespace EcommercePOO.Modelos
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string correo, string contraseña)
            : base(id, nombre, correo, contraseña)
        {
        }

        public void GestionarInventario(List<Producto> productos)
        {
            foreach (var p in productos)
            {
                System.Console.WriteLine(p.Nombre);
            }
        }
    }
}
using System;

namespace EcommercePOO.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public Usuario(int id, string nombre, string correo, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Contraseña = contraseña;
        }

        // Destructor opcional
        ~Usuario()
        {
            Console.WriteLine("Usuario eliminado");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVacaciones1
{
    public class Usuario
    {
        public string Rol { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public Usuario()
        {
        }

        public Usuario(string rol, string user, string password)
        {
            Rol = rol;
            User = user;
            Password = password;
        }

        public string MostrarSaludo()
        {
            return $"Bienvenido: {Rol} {User} {Password}";
        }
    }


    public static class Sesion
    {
        public static Usuario UsuarioActual { get; set; }
    }
}

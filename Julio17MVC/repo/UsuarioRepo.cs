using Julio17MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio17MVC.repo
{
    public class UsuarioRepo
    {
        public static Usuario Obtener(string idUsuario)
        {
            var resultado = new Usuario();
            using (var contexto = new basejorgeContext())
            {
                resultado = contexto.Usuarios.Find(idUsuario);
            }
            return resultado;
        }
        public static string ValidarUsuarioV2(Usuario usuarioDigitado)
        {
            var resultado = "";
            using (var contexto = new basejorgeContext())
            {
                var usuario=contexto.Usuarios
                    .Where( u=>u.Usuario1==usuarioDigitado.Usuario1)
                    .Where(u=>u.Clave==usuarioDigitado.Clave)
                    .FirstOrDefault();  // si no hay usuario, devuelve nulo.
                if(usuario==null)
                {
                    resultado="Usuario o clave incorrecta";
                } else
                {
                    resultado="ok";
                }
            }

            return resultado;
        }
        public static string ValidarUsuario(Usuario usuarioDigitado)
        {
            var resultado = "";
            var usuarioBase = Obtener(usuarioDigitado.Usuario1);
            if (usuarioBase == null)
            {
                resultado = "Usuario no existe";
            }
            else
            {
                if (usuarioBase.Clave == usuarioDigitado.Clave)
                {
                    resultado = "ok";
                }
                else
                {
                    resultado = "clave incorrecta";
                }
            }
            return resultado;

        }
    }
}

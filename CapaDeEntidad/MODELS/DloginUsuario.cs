using CapaDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidad.MODELS
{
    public class DloginUsuario
    {
        LoginUsuario login = new LoginUsuario();

        public bool Login(string usuario, string contrasenia, string tipo)
        {
            return login.Login(usuario, contrasenia, tipo);
        }
    }
}

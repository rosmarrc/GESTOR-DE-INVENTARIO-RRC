using CapaDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidad.MODELS
{
    public class DexistUsuario
    {
        ExistUsuario exist = new ExistUsuario();
        public bool ValidarUsuario(string usuario)
        {
            return exist.ValidarUsuario(usuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeDatos.Entidades;
using CapaDeNegocio.Atributos;

namespace CapaDeEntidad.CRUD
{
    public class DUsuarios
    {
        Usuarios Usuarios = new Usuarios();

        public void CrarUsuario(AtributosUsuariosDB obj)
        {
            Usuarios.CrearUsuario(obj);
        }
    }
}

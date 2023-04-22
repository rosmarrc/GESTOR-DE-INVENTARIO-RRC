using CapaDeDatos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.modelos
{
    public class ExistUsuario
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool ValidarUsuario(string usuario)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Nom_Usuario = @Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            if (dr.HasRows)
            {
                cmd.Connection = c.CloseConnection();
                return true;
            }
            else
            {
                cmd.Connection = c.CloseConnection();
                return false;
            }
        }
    }
}

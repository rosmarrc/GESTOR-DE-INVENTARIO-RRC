using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDeNegocio.Cache;
using CapaDeDatos.Conexion;

namespace CapaDeDatos.modelos
{
    public class LoginUsuario
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool Login(string usuario, string contrasenia, string tipo)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Nom_Usuario = @usuario AND Contrasenia = @contrasenia AND Tipo = @tipo";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    AtributosUsuario.ID = dr.GetInt32(0);
                    AtributosUsuario.Nombre = dr.GetString(1);
                    AtributosUsuario.Apellido = dr.GetString(2);
                    AtributosUsuario.Nom_Usuario = dr.GetString(3);
                    AtributosUsuario.Contrasenia = dr.GetString(4);
                    AtributosUsuario.Tipo = dr.GetString(5);
                }
                cmd.Connection = c.CloseConnection();
                return true;
            }
            else cmd.Connection = c.CloseConnection();
            return false;
        }
    }
}

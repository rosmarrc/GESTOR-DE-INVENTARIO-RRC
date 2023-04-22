using CapaDeDatos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.modelos
{
    public class EliminarArticulo
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool EliminarArt(int id)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "DELETE FROM Articulos WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);


            int result = cmd.ExecuteNonQuery();

            if (result > 0)
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

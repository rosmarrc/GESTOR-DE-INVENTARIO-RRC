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
    public class InsertarArticulo
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();

        public bool InsertarArt(string descripcion, int costo, int precio, int unidades)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "INSERT INTO Articulos (Descripcion, Costo, Precio, Unidades) VALUES (@Descripcion, @Costo, @Precio, @Unidades)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd.Parameters.AddWithValue("@Costo", costo);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Unidades", unidades);
           


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

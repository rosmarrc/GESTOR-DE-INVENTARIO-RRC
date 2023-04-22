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
    public class ModificarArticulo
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool ModificarArt(int id, string descripcion, int costo, int precio, int unidades)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "UPDATE Articulos SET Descripcion=@Descripcion, Costo=@Costo, Precio=@Precio, Unidades=@Unidades WHERE Id=@Id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd.Parameters.AddWithValue("@Costo", costo);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Unidades", unidades);
           
            
            dr = cmd.ExecuteReader();

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace CapaDeDatos.Conexion
{
    public class conexionDB
    {
        private SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=CapaDeDatosGestor;Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;

        }
        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;

        }

    }
}

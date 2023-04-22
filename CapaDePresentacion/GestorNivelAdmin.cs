using CapaDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos.Conexion;

namespace CapaDePresentacion
{
    public partial class GestorNivelAdmin : Form
    {
        public GestorNivelAdmin()
        {
            InitializeComponent();
        }
        private void MostrarArticulos()
        {
            string connectionString = "Data Source=.;Initial Catalog=CapaDeDatosGestor;Integrated Security=True";
            string query = "SELECT * FROM Articulos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvArticulos.DataSource = dataTable;
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.posicionpanel = 1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string descripcion = txtdescripcion.Text;
            int costo = int.Parse(txtcosto.Text);
            int precio = int.Parse(txtprecio.Text);
            int unidades = int.Parse(numunidades.Text);

            InsertarArticulo insertarArticulo = new InsertarArticulo();
            bool resultado = insertarArticulo.InsertarArt(descripcion, costo, precio, unidades);
            if (resultado)
            {
                MessageBox.Show("El Articulo se ha insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar insertar el Articulo.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);


            EliminarArticulo eliminarArticulo = new EliminarArticulo();
            bool resultado3 = eliminarArticulo.EliminarArt(id);
            if (resultado3)
            {
                MessageBox.Show("El Articulo ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún Articulo con el Id especificado.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string descripcion = txtdescripcion.Text;
            int costo = int.Parse(txtcosto.Text);
            int precio = int.Parse(txtprecio.Text);
            int unidades = int.Parse(numunidades.Text);

            ModificarArticulo modificarArticulo = new ModificarArticulo();
            bool resultado2 = modificarArticulo.ModificarArt(id, descripcion, costo, precio, unidades);
            if (!resultado2)
            {
                MessageBox.Show("Articulo modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al modificar el Articulo.");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarArticulos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            

            string connectionString = "Data Source=.;Initial Catalog=CapaDeDatosGestor;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Articulos WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtdescripcion.Text = reader["Descripcion"].ToString();
                            txtcosto.Text = reader["Costo"].ToString();
                            txtprecio.Text = reader["Precio"].ToString();
                            numunidades.Text = reader["Unidades"].ToString();                         
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el Id especificado.");
                    }
                }
            }
        }
    }
}


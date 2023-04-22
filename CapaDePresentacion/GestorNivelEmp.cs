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

namespace CapaDePresentacion
{
    public partial class GestorNivelEmp : Form
    {
        public GestorNivelEmp()
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

        private void btnCerrarSesionE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.posicionpanel = 1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarArticulos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" && txtdescripcion.Text == "")
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtid.Text != "")
                {
                    int id = int.Parse(txtid.Text);
                    string connectionString2 = "Data Source=.;Initial Catalog=CapaDeDatosGestor;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString2))
                    {
                        string query = "SELECT * FROM Articulos WHERE Id=@Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);


                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                dgvArticulos.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con el Id o Descripcion especificado.");
                                txtid.Text = "";
                                txtdescripcion.Text = "";
                                txtid.Focus();


                            }
                        }
                    }
                }


                if (txtdescripcion.Text != "")
                {
                    string descripcion = txtdescripcion.Text;

                    string connectionString = "Data Source=.;Initial Catalog=CapaDeDatosGestor;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM Articulos WHERE Descripcion=@Descripcion";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@Descripcion", descripcion);

                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                dgvArticulos.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con el Id o Descripcion especificado.");
                                txtid.Text = "";
                                txtdescripcion.Text = "";
                                txtid.Focus();
                            }
                        }
                    }
                }
            }
        }
    }
}

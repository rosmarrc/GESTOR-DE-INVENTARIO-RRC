using CapaDeDatos.Entidades;
using CapaDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos.Conexion;
using CapaDeEntidad.CRUD;
using CapaDeEntidad.MODELS;
using CapaDeNegocio.Atributos;
using CapaDeNegocio.Cache;

namespace CapaDePresentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
       

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.posicionpanel = 1;
        }

        private void btnSalirR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DUsuarios usuarios = new DUsuarios();
        AtributosUsuariosDB atributos = new AtributosUsuariosDB();
        DexistUsuario existUsuario = new DexistUsuario();
        private void btnRegistrarR_Click(object sender, EventArgs e)
        {
            if (txtapellidosR.Text == "" || txtnombreR.Text == "" || txtusuarioR.Text == "" || txtclaveR.Text == "" || cmbtipoR.Text =="")
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                atributos.Nombre1 = txtnombreR.Text;
                atributos.Apellido1 = txtapellidosR.Text;
                atributos.Nom_Usuario1 = txtusuarioR.Text;
                atributos.Contrasenia1 = txtclaveR.Text;
                atributos.Tipo1 = cmbtipoR.Text;
                var exist = existUsuario.ValidarUsuario(txtusuarioR.Text);
                if (exist) MessageBox.Show("Este usuario esta en uso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    usuarios.CrarUsuario(atributos);
                    MessageBox.Show("Este usuario se registro exitosamente!", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnombreR.Text = "";
                    txtapellidosR.Text = "";
                    txtusuarioR.Text = "";
                    txtclaveR.Text = "";
                    cmbtipoR.Text = "";
                }
            }
        }
    }
}

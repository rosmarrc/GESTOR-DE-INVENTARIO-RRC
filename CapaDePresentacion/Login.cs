using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidad.MODELS;
using CapaDeDatos.Conexion;

namespace CapaDePresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.posicionpanel = 2;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "")
            {
                if (txtclave.Text != "")
                {
                    if (cmbtipo.Text != "")
                    {
                        DloginUsuario usuariomodelo = new DloginUsuario();
                        var validar = usuariomodelo.Login(txtusuario.Text, txtclave.Text, cmbtipo.Text);
                        if (validar)
                        {
                            switch(cmbtipo.Text)
                            {
                                case "Administrador":
                                    this.Hide();
                                    Program.posicionpanel = 3;
                                    break;
                                case "Empleado":
                                    this.Hide();
                                    Program.posicionpanel = 4;
                                    break;
                            }

                        }
                        else MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }else MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Contraseña Incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else MessageBox.Show("Usuario incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}

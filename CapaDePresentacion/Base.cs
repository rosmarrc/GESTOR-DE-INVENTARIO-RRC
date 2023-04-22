using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        void abrirForm(Form form)
        {
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form formhijo = form;
            form.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formhijo);
            formhijo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            switch(Program.posicionpanel)
            {
                case 1: abrirForm(new Login());
                    break;
                case 2: abrirForm(new Registro());
                    break;
                case 3: abrirForm(new GestorNivelAdmin());
                    break;
                case 4: abrirForm(new GestorNivelEmp());
                    break;
            }
        }
        private void Base_Load(object sender, EventArgs e)
        {
                abrirForm(new Login());
        }
    }
}

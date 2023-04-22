namespace CapaDePresentacion
{
    partial class GestorNivelEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCerrarSesionE = new Button();
            dgvArticulos = new DataGridView();
            btnBuscar = new Button();
            txtdescripcion = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(76, 29);
            label1.Name = "label1";
            label1.Size = new Size(427, 92);
            label1.TabIndex = 3;
            label1.Text = "GESTOR DE INVENTARIO\r\n(EMPLEADO)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesionE
            // 
            btnCerrarSesionE.Anchor = AnchorStyles.Top;
            btnCerrarSesionE.BackColor = Color.Navy;
            btnCerrarSesionE.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionE.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesionE.ForeColor = Color.LightSkyBlue;
            btnCerrarSesionE.Location = new Point(580, 12);
            btnCerrarSesionE.Name = "btnCerrarSesionE";
            btnCerrarSesionE.Size = new Size(208, 55);
            btnCerrarSesionE.TabIndex = 29;
            btnCerrarSesionE.Text = "Cerrar Sesion";
            btnCerrarSesionE.UseVisualStyleBackColor = false;
            btnCerrarSesionE.Click += btnCerrarSesionE_Click;
            // 
            // dgvArticulos
            // 
            dgvArticulos.BackgroundColor = Color.SkyBlue;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Dock = DockStyle.Bottom;
            dgvArticulos.Location = new Point(0, 433);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.Size = new Size(800, 184);
            dgvArticulos.TabIndex = 31;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom;
            btnBuscar.BackColor = Color.Navy;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.LightSkyBlue;
            btnBuscar.Location = new Point(12, 372);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(242, 55);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar Producto";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Anchor = AnchorStyles.Top;
            txtdescripcion.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(404, 233);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(218, 39);
            txtdescripcion.TabIndex = 35;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top;
            txtid.Cursor = Cursors.IBeam;
            txtid.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.Location = new Point(404, 188);
            txtid.Name = "txtid";
            txtid.Size = new Size(218, 39);
            txtid.TabIndex = 34;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(134, 184);
            label6.Name = "label6";
            label6.Size = new Size(264, 43);
            label6.TabIndex = 33;
            label6.Text = "ID de Producto:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(180, 230);
            label5.Name = "label5";
            label5.Size = new Size(212, 43);
            label5.TabIndex = 32;
            label5.Text = "Descripcion:";
            // 
            // btnMostrar
            // 
            btnMostrar.Anchor = AnchorStyles.Bottom;
            btnMostrar.BackColor = Color.Navy;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.LightSkyBlue;
            btnMostrar.Location = new Point(531, 372);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(257, 55);
            btnMostrar.TabIndex = 36;
            btnMostrar.Text = "Mostrar Inventario";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // GestorNivelEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 617);
            Controls.Add(btnMostrar);
            Controls.Add(txtdescripcion);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvArticulos);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrarSesionE);
            Controls.Add(label1);
            Name = "GestorNivelEmp";
            Text = "GestorNivelEmp";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrarSesionE;
        private DataGridView dgvArticulos;
        private Button btnBuscar;
        private TextBox txtdescripcion;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Button btnMostrar;
    }
}
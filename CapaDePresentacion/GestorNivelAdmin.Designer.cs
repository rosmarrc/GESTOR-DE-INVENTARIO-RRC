namespace CapaDePresentacion
{
    partial class GestorNivelAdmin
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
            txtprecio = new TextBox();
            txtcosto = new TextBox();
            txtdescripcion = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            numunidades = new NumericUpDown();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvArticulos = new DataGridView();
            btnCerrarSesion = new Button();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numunidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(92, 12);
            label1.Name = "label1";
            label1.Size = new Size(427, 92);
            label1.TabIndex = 2;
            label1.Text = "GESTOR DE INVENTARIO\r\n(ADMINISTRADOR)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtprecio
            // 
            txtprecio.Anchor = AnchorStyles.Top;
            txtprecio.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.Location = new Point(279, 252);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(218, 39);
            txtprecio.TabIndex = 21;
            // 
            // txtcosto
            // 
            txtcosto.Anchor = AnchorStyles.Top;
            txtcosto.Cursor = Cursors.IBeam;
            txtcosto.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcosto.Location = new Point(279, 207);
            txtcosto.Name = "txtcosto";
            txtcosto.Size = new Size(218, 39);
            txtcosto.TabIndex = 20;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Anchor = AnchorStyles.Top;
            txtdescripcion.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(279, 162);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(218, 39);
            txtdescripcion.TabIndex = 19;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top;
            txtid.Cursor = Cursors.IBeam;
            txtid.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.Location = new Point(279, 117);
            txtid.Name = "txtid";
            txtid.Size = new Size(218, 39);
            txtid.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(9, 113);
            label6.Name = "label6";
            label6.Size = new Size(264, 43);
            label6.TabIndex = 17;
            label6.Text = "ID de Producto:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(55, 159);
            label5.Name = "label5";
            label5.Size = new Size(212, 43);
            label5.TabIndex = 16;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(148, 207);
            label4.Name = "label4";
            label4.Size = new Size(119, 43);
            label4.TabIndex = 15;
            label4.Text = "Costo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(138, 252);
            label2.Name = "label2";
            label2.Size = new Size(129, 43);
            label2.TabIndex = 14;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(92, 294);
            label3.Name = "label3";
            label3.Size = new Size(175, 43);
            label3.TabIndex = 13;
            label3.Text = "Unidades:";
            // 
            // numunidades
            // 
            numunidades.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numunidades.Location = new Point(279, 298);
            numunidades.Name = "numunidades";
            numunidades.Size = new Size(218, 39);
            numunidades.TabIndex = 22;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top;
            btnInsertar.BackColor = Color.Navy;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.ForeColor = Color.LightSkyBlue;
            btnInsertar.Location = new Point(516, 117);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(274, 55);
            btnInsertar.TabIndex = 23;
            btnInsertar.Text = "Insertar Producto";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top;
            btnModificar.BackColor = Color.Navy;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.LightSkyBlue;
            btnModificar.Location = new Point(516, 191);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(274, 55);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar Producto";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.Navy;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.LightSkyBlue;
            btnEliminar.Location = new Point(516, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(274, 55);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom;
            btnBuscar.BackColor = Color.Navy;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.LightSkyBlue;
            btnBuscar.Location = new Point(9, 372);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(242, 55);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar Producto";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvArticulos
            // 
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvArticulos.BackgroundColor = Color.SkyBlue;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(0, 433);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.Size = new Size(800, 184);
            dgvArticulos.TabIndex = 27;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top;
            btnCerrarSesion.BackColor = Color.Navy;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.LightSkyBlue;
            btnCerrarSesion.Location = new Point(580, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(208, 55);
            btnCerrarSesion.TabIndex = 28;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
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
            btnMostrar.TabIndex = 29;
            btnMostrar.Text = "Mostrar Inventario";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // GestorNivelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 617);
            Controls.Add(btnMostrar);
            Controls.Add(btnCerrarSesion);
            Controls.Add(dgvArticulos);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(numunidades);
            Controls.Add(txtprecio);
            Controls.Add(txtcosto);
            Controls.Add(txtdescripcion);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "GestorNivelAdmin";
            Text = "GestorNivelAdmin";
            ((System.ComponentModel.ISupportInitialize)numunidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtprecio;
        private TextBox txtcosto;
        private TextBox txtdescripcion;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private NumericUpDown numunidades;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvArticulos;
        private Button btnCerrarSesion;
        private Button btnMostrar;
    }
}
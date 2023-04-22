namespace CapaDePresentacion
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtusuario = new TextBox();
            cmbtipo = new ComboBox();
            txtclave = new TextBox();
            btnIngresar = new Button();
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(256, 34);
            label1.Name = "label1";
            label1.Size = new Size(311, 46);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(168, 148);
            label2.Name = "label2";
            label2.Size = new Size(207, 43);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(226, 103);
            label3.Name = "label3";
            label3.Size = new Size(149, 43);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(275, 193);
            label4.Name = "label4";
            label4.Size = new Size(100, 43);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // txtusuario
            // 
            txtusuario.Anchor = AnchorStyles.Top;
            txtusuario.Cursor = Cursors.IBeam;
            txtusuario.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(381, 106);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(218, 39);
            txtusuario.TabIndex = 4;
            // 
            // cmbtipo
            // 
            cmbtipo.Anchor = AnchorStyles.Top;
            cmbtipo.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cmbtipo.Location = new Point(381, 196);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(218, 43);
            cmbtipo.TabIndex = 6;
            // 
            // txtclave
            // 
            txtclave.Anchor = AnchorStyles.Top;
            txtclave.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(381, 151);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(218, 39);
            txtclave.TabIndex = 7;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top;
            btnIngresar.BackColor = Color.Navy;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.LightSkyBlue;
            btnIngresar.Location = new Point(168, 276);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(207, 55);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top;
            btnRegistrar.BackColor = Color.Navy;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.LightSkyBlue;
            btnRegistrar.Location = new Point(392, 276);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(207, 55);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.Navy;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.LightSkyBlue;
            btnSalir.Location = new Point(652, 550);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 55);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 617);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtclave);
            Controls.Add(cmbtipo);
            Controls.Add(txtusuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtusuario;
        private ComboBox cmbtipo;
        private TextBox txtclave;
        private Button btnIngresar;
        private Button btnRegistrar;
        private Button btnSalir;
    }
}
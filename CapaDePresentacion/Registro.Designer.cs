namespace CapaDePresentacion
{
    partial class Registro
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtapellidosR = new TextBox();
            txtnombreR = new TextBox();
            txtclaveR = new TextBox();
            txtusuarioR = new TextBox();
            cmbtipoR = new ComboBox();
            btnRegistrarR = new Button();
            btnSalirR = new Button();
            btnRetroceder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(198, 38);
            label1.Name = "label1";
            label1.Size = new Size(427, 46);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE USUSARIO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(287, 290);
            label3.Name = "label3";
            label3.Size = new Size(100, 43);
            label3.TabIndex = 3;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(180, 245);
            label2.Name = "label2";
            label2.Size = new Size(207, 43);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(238, 200);
            label4.Name = "label4";
            label4.Size = new Size(149, 43);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(212, 155);
            label5.Name = "label5";
            label5.Size = new Size(175, 43);
            label5.TabIndex = 6;
            label5.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(192, 110);
            label6.Name = "label6";
            label6.Size = new Size(195, 43);
            label6.TabIndex = 7;
            label6.Text = "Nombre(s):";
            // 
            // txtapellidosR
            // 
            txtapellidosR.Anchor = AnchorStyles.Top;
            txtapellidosR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtapellidosR.Location = new Point(393, 158);
            txtapellidosR.Name = "txtapellidosR";
            txtapellidosR.Size = new Size(218, 39);
            txtapellidosR.TabIndex = 9;
            // 
            // txtnombreR
            // 
            txtnombreR.Anchor = AnchorStyles.Top;
            txtnombreR.Cursor = Cursors.IBeam;
            txtnombreR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombreR.Location = new Point(393, 113);
            txtnombreR.Name = "txtnombreR";
            txtnombreR.Size = new Size(218, 39);
            txtnombreR.TabIndex = 8;
            // 
            // txtclaveR
            // 
            txtclaveR.Anchor = AnchorStyles.Top;
            txtclaveR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtclaveR.Location = new Point(393, 248);
            txtclaveR.Name = "txtclaveR";
            txtclaveR.Size = new Size(218, 39);
            txtclaveR.TabIndex = 11;
            // 
            // txtusuarioR
            // 
            txtusuarioR.Anchor = AnchorStyles.Top;
            txtusuarioR.Cursor = Cursors.IBeam;
            txtusuarioR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuarioR.Location = new Point(393, 203);
            txtusuarioR.Name = "txtusuarioR";
            txtusuarioR.Size = new Size(218, 39);
            txtusuarioR.TabIndex = 10;
            // 
            // cmbtipoR
            // 
            cmbtipoR.Anchor = AnchorStyles.Top;
            cmbtipoR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtipoR.FormattingEnabled = true;
            cmbtipoR.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cmbtipoR.Location = new Point(393, 293);
            cmbtipoR.Name = "cmbtipoR";
            cmbtipoR.Size = new Size(218, 43);
            cmbtipoR.TabIndex = 12;
            // 
            // btnRegistrarR
            // 
            btnRegistrarR.Anchor = AnchorStyles.Top;
            btnRegistrarR.BackColor = Color.Navy;
            btnRegistrarR.FlatStyle = FlatStyle.Flat;
            btnRegistrarR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarR.ForeColor = Color.LightSkyBlue;
            btnRegistrarR.Location = new Point(300, 359);
            btnRegistrarR.Name = "btnRegistrarR";
            btnRegistrarR.Size = new Size(207, 55);
            btnRegistrarR.TabIndex = 13;
            btnRegistrarR.Text = "Registrar";
            btnRegistrarR.UseVisualStyleBackColor = false;
            btnRegistrarR.Click += btnRegistrarR_Click;
            // 
            // btnSalirR
            // 
            btnSalirR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalirR.BackColor = Color.Navy;
            btnSalirR.FlatStyle = FlatStyle.Flat;
            btnSalirR.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalirR.ForeColor = Color.LightSkyBlue;
            btnSalirR.Location = new Point(652, 550);
            btnSalirR.Name = "btnSalirR";
            btnSalirR.Size = new Size(136, 55);
            btnSalirR.TabIndex = 14;
            btnSalirR.Text = "Salir";
            btnSalirR.UseVisualStyleBackColor = false;
            btnSalirR.Click += btnSalirR_Click;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRetroceder.BackColor = Color.Navy;
            btnRetroceder.FlatStyle = FlatStyle.Flat;
            btnRetroceder.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetroceder.ForeColor = Color.LightSkyBlue;
            btnRetroceder.Location = new Point(12, 550);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(167, 55);
            btnRetroceder.TabIndex = 15;
            btnRetroceder.Text = "Retroceder";
            btnRetroceder.UseVisualStyleBackColor = false;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 617);
            Controls.Add(btnRetroceder);
            Controls.Add(btnSalirR);
            Controls.Add(btnRegistrarR);
            Controls.Add(cmbtipoR);
            Controls.Add(txtclaveR);
            Controls.Add(txtusuarioR);
            Controls.Add(txtapellidosR);
            Controls.Add(txtnombreR);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtapellidosR;
        private TextBox txtnombreR;
        private TextBox txtclaveR;
        private TextBox txtusuarioR;
        private ComboBox cmbtipoR;
        private Button btnRegistrarR;
        private Button btnSalirR;
        private Button btnRetroceder;
    }
}
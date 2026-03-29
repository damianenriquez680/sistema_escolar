namespace DS3_SistemaEscolarBD.Catalogo.Academico
{
    partial class AgregarEditar
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
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtGrado = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbCiudad = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.GripMargin = new Padding(6, 2, 2, 2);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(349, 27);
            toolStrip1.TabIndex = 36;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageTransparentColor = Color.MediumSlateBlue;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 24);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Image = Properties.Resources.Cancelar;
            Cancelar.ImageTransparentColor = Color.Magenta;
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(90, 24);
            Cancelar.Text = "Cancelar";
            Cancelar.Click += Cancelar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(30, 61);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 41;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 255, 192);
            txtNombre.Location = new Point(103, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 27);
            txtNombre.TabIndex = 42;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(255, 255, 192);
            txtApellidos.Location = new Point(103, 91);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(199, 27);
            txtApellidos.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 43;
            label2.Text = "Apellidos:";
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.FromArgb(255, 255, 192);
            txtGrado.Location = new Point(103, 124);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(199, 27);
            txtGrado.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(44, 127);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 45;
            label3.Text = "Grado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(38, 160);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 47;
            label4.Text = "Ciudad:";
            // 
            // cbCiudad
            // 
            cbCiudad.BackColor = Color.FromArgb(255, 255, 192);
            cbCiudad.FormattingEnabled = true;
            cbCiudad.Location = new Point(103, 157);
            cbCiudad.Name = "cbCiudad";
            cbCiudad.Size = new Size(199, 28);
            cbCiudad.TabIndex = 66;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(cbCiudad);
            Controls.Add(label4);
            Controls.Add(txtGrado);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(367, 252);
            MinimumSize = new Size(367, 252);
            Name = "AgregarEditar";
            Text = "Agregar y Editar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtGrado;
        private Label label3;
        private Label label4;
        private ComboBox cbCiudad;
    }
}
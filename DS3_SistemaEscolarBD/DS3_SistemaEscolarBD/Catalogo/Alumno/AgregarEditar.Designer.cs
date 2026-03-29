namespace DS3_SistemaEscolarBD.Catalogo.Alumno
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
            label3 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cbEstatus = new ComboBox();
            cbCiudad = new ComboBox();
            label4 = new Label();
            cbCarrera = new ComboBox();
            label5 = new Label();
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
            toolStrip1.MaximumSize = new Size(367, 260);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(349, 27);
            toolStrip1.TabIndex = 36;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageTransparentColor = Color.Magenta;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(58, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 55;
            label3.Text = "Estatus:";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(255, 255, 192);
            txtApellidos.Location = new Point(122, 83);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(189, 27);
            txtApellidos.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(41, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 53;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 255, 192);
            txtNombre.Location = new Point(122, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 27);
            txtNombre.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(49, 53);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 51;
            label1.Text = "Nombre:";
            // 
            // cbEstatus
            // 
            cbEstatus.BackColor = Color.FromArgb(255, 255, 192);
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo", "Egresado", "Baja definitiva" });
            cbEstatus.Location = new Point(122, 116);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(189, 28);
            cbEstatus.TabIndex = 56;
            // 
            // cbCiudad
            // 
            cbCiudad.BackColor = Color.FromArgb(255, 255, 192);
            cbCiudad.FormattingEnabled = true;
            cbCiudad.Items.AddRange(new object[] { "Activo", "Inactivo", "Egresado", "Baja definitiva" });
            cbCiudad.Location = new Point(122, 184);
            cbCiudad.Name = "cbCiudad";
            cbCiudad.Size = new Size(189, 28);
            cbCiudad.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(57, 187);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 57;
            label4.Text = "Ciudad:";
            // 
            // cbCarrera
            // 
            cbCarrera.BackColor = Color.FromArgb(255, 255, 192);
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Items.AddRange(new object[] { "Activo", "Inactivo", "Egresado", "Baja definitiva" });
            cbCarrera.Location = new Point(122, 150);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(189, 28);
            cbCarrera.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(56, 153);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 59;
            label5.Text = "Carrera:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 213);
            ControlBox = false;
            Controls.Add(cbCarrera);
            Controls.Add(label5);
            Controls.Add(cbCiudad);
            Controls.Add(label4);
            Controls.Add(cbEstatus);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(367, 260);
            MinimumSize = new Size(367, 260);
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
        private Label label3;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cbEstatus;
        private ComboBox cbCiudad;
        private Label label4;
        private ComboBox cbCarrera;
        private Label label5;
    }
}
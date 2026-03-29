namespace DS3_SistemaEscolarBD.Catalogo.Grupo
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
            cbHorario = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label6 = new Label();
            cbAula = new ComboBox();
            cbCarrera = new ComboBox();
            cbAlumno = new ComboBox();
            cbMaestro = new ComboBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
            label2 = new Label();
            cbMateria = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbHorario
            // 
            cbHorario.BackColor = Color.FromArgb(255, 255, 192);
            cbHorario.FormattingEnabled = true;
            cbHorario.Items.AddRange(new object[] { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00", "18:00 - 19:00", "19:00 - 20:00" });
            cbHorario.Location = new Point(111, 138);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(199, 28);
            cbHorario.TabIndex = 77;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 192);
            label10.Location = new Point(40, 73);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 76;
            label10.Text = "Maestro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Location = new Point(67, 107);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 75;
            label8.Text = "Aula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(42, 39);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 74;
            label4.Text = "Alumno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(45, 174);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 73;
            label6.Text = "Carrera:";
            // 
            // cbAula
            // 
            cbAula.BackColor = Color.FromArgb(255, 255, 192);
            cbAula.FormattingEnabled = true;
            cbAula.Location = new Point(112, 104);
            cbAula.Name = "cbAula";
            cbAula.Size = new Size(199, 28);
            cbAula.TabIndex = 72;
            // 
            // cbCarrera
            // 
            cbCarrera.BackColor = Color.FromArgb(255, 255, 192);
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(111, 171);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(199, 28);
            cbCarrera.TabIndex = 71;
            // 
            // cbAlumno
            // 
            cbAlumno.BackColor = Color.FromArgb(255, 255, 192);
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(112, 36);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(199, 28);
            cbAlumno.TabIndex = 70;
            // 
            // cbMaestro
            // 
            cbMaestro.BackColor = Color.FromArgb(255, 255, 192);
            cbMaestro.FormattingEnabled = true;
            cbMaestro.Location = new Point(112, 70);
            cbMaestro.Name = "cbMaestro";
            cbMaestro.Size = new Size(200, 28);
            cbMaestro.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(42, 141);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 68;
            label1.Text = "Horario:";
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
            toolStrip1.TabIndex = 67;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(42, 208);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 79;
            label2.Text = "Materia:";
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.FromArgb(255, 255, 192);
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(111, 205);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(199, 28);
            cbMateria.TabIndex = 78;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 235);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(cbMateria);
            Controls.Add(cbHorario);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(cbAula);
            Controls.Add(cbCarrera);
            Controls.Add(cbAlumno);
            Controls.Add(cbMaestro);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(367, 282);
            MinimumSize = new Size(367, 282);
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbHorario;
        private Label label10;
        private Label label8;
        private Label label4;
        private Label label6;
        private ComboBox cbAula;
        private ComboBox cbCarrera;
        private ComboBox cbAlumno;
        private ComboBox cbMaestro;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private Label label2;
        private ComboBox cbMateria;
    }
}
namespace DS3_SistemaEscolarBD.Catalogo.Reinscripcion
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
            cbGrupo = new ComboBox();
            cbAlumno = new ComboBox();
            txtCalificacion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbGrupo
            // 
            cbGrupo.BackColor = Color.FromArgb(255, 255, 192);
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(113, 61);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(199, 28);
            cbGrupo.TabIndex = 65;
            // 
            // cbAlumno
            // 
            cbAlumno.BackColor = Color.FromArgb(255, 255, 192);
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(113, 108);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(199, 28);
            cbAlumno.TabIndex = 64;
            // 
            // txtCalificacion
            // 
            txtCalificacion.BackColor = Color.FromArgb(255, 255, 192);
            txtCalificacion.Location = new Point(113, 159);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(199, 27);
            txtCalificacion.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(21, 162);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 62;
            label3.Text = "Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(46, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 61;
            label2.Text = "Alumno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(54, 64);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 60;
            label1.Text = "Grupo:";
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
            toolStrip1.TabIndex = 59;
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
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(cbGrupo);
            Controls.Add(cbAlumno);
            Controls.Add(txtCalificacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(367, 252);
            MinimumSize = new Size(367, 252);
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGrupo;
        private ComboBox cbAlumno;
        private TextBox txtCalificacion;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
    }
}
namespace DS3_SistemaEscolarBD.Catalogo.Aula
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
            txtEdificio = new TextBox();
            txtNombreAula = new TextBox();
            txtCapaMax = new TextBox();
            txtPiso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // txtEdificio
            // 
            txtEdificio.BackColor = Color.FromArgb(255, 255, 192);
            txtEdificio.Location = new Point(161, 72);
            txtEdificio.Name = "txtEdificio";
            txtEdificio.Size = new Size(147, 27);
            txtEdificio.TabIndex = 53;
            // 
            // txtNombreAula
            // 
            txtNombreAula.BackColor = Color.FromArgb(255, 255, 192);
            txtNombreAula.Location = new Point(161, 105);
            txtNombreAula.Name = "txtNombreAula";
            txtNombreAula.Size = new Size(147, 27);
            txtNombreAula.TabIndex = 54;
            // 
            // txtCapaMax
            // 
            txtCapaMax.BackColor = Color.FromArgb(255, 255, 192);
            txtCapaMax.Location = new Point(161, 171);
            txtCapaMax.Name = "txtCapaMax";
            txtCapaMax.Size = new Size(147, 27);
            txtCapaMax.TabIndex = 56;
            // 
            // txtPiso
            // 
            txtPiso.BackColor = Color.FromArgb(255, 255, 192);
            txtPiso.Location = new Point(161, 138);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(147, 27);
            txtPiso.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(15, 174);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 58;
            label1.Text = "Capacidad máxima:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(105, 141);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 59;
            label2.Text = "Piso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(31, 108);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 60;
            label3.Text = "Nombre del aula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(87, 74);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 61;
            label5.Text = "Edificio:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPiso);
            Controls.Add(txtCapaMax);
            Controls.Add(txtNombreAula);
            Controls.Add(txtEdificio);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(367, 252);
            MdiChildrenMinimizedAnchorBottom = false;
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
        private TextBox txtEdificio;
        private TextBox txtNombreAula;
        private TextBox txtCapaMax;
        private TextBox txtPiso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}
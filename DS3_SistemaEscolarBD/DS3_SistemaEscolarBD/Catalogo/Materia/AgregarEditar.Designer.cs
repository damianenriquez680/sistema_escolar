namespace DS3_SistemaEscolarBD.Catalogo.Materia
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
            nCreditos = new NumericUpDown();
            txtNombreMateria = new TextBox();
            label5 = new Label();
            label6 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nCreditos).BeginInit();
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
            toolStrip1.TabIndex = 35;
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
            // nCreditos
            // 
            nCreditos.BackColor = Color.FromArgb(255, 255, 192);
            nCreditos.Location = new Point(153, 127);
            nCreditos.Name = "nCreditos";
            nCreditos.Size = new Size(184, 27);
            nCreditos.TabIndex = 34;
            nCreditos.ThousandsSeparator = true;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.BackColor = Color.FromArgb(255, 255, 192);
            txtNombreMateria.Location = new Point(153, 80);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(184, 27);
            txtNombreMateria.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(80, 129);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 29;
            label5.Text = "Creditos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(25, 83);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 28;
            label6.Text = "Nombre Materia:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(nCreditos);
            Controls.Add(txtNombreMateria);
            Controls.Add(label5);
            Controls.Add(label6);
            MaximumSize = new Size(367, 252);
            MinimumSize = new Size(367, 252);
            Name = "AgregarEditar";
            Text = "Agregar y Editar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nCreditos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private NumericUpDown nCreditos;
        private TextBox txtNombreMateria;
        private Label label5;
        private Label label6;
    }
}
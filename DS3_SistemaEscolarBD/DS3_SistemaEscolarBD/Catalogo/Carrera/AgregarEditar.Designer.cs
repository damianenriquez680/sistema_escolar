namespace DS3_SistemaEscolarBD.Catalogo.Carrera
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
            label1 = new Label();
            label2 = new Label();
            txtNombreCarrera = new TextBox();
            txtSiglasCarrera = new TextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(19, 70);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 55;
            label1.Text = "Nombre de carrera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(35, 113);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 56;
            label2.Text = "Siglas de carrera:";
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.BackColor = Color.FromArgb(255, 255, 192);
            txtNombreCarrera.Location = new Point(163, 67);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.Size = new Size(174, 27);
            txtNombreCarrera.TabIndex = 57;
            // 
            // txtSiglasCarrera
            // 
            txtSiglasCarrera.BackColor = Color.FromArgb(255, 255, 192);
            txtSiglasCarrera.Location = new Point(163, 110);
            txtSiglasCarrera.Name = "txtSiglasCarrera";
            txtSiglasCarrera.Size = new Size(174, 27);
            txtSiglasCarrera.TabIndex = 58;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(txtSiglasCarrera);
            Controls.Add(txtNombreCarrera);
            Controls.Add(label2);
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
        private Label label1;
        private Label label2;
        private TextBox txtNombreCarrera;
        private TextBox txtSiglasCarrera;
    }
}
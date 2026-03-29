namespace DS3_SistemaEscolarBD.Catalogo.Ciudad
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
            txtSiglasCiudad = new TextBox();
            txtNombreCiudad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbEstado = new ComboBox();
            label3 = new Label();
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
            toolStrip1.Size = new Size(365, 27);
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
            // txtSiglasCiudad
            // 
            txtSiglasCiudad.BackColor = Color.FromArgb(255, 255, 192);
            txtSiglasCiudad.Location = new Point(173, 117);
            txtSiglasCiudad.Name = "txtSiglasCiudad";
            txtSiglasCiudad.Size = new Size(147, 27);
            txtSiglasCiudad.TabIndex = 62;
            // 
            // txtNombreCiudad
            // 
            txtNombreCiudad.BackColor = Color.FromArgb(255, 255, 192);
            txtNombreCiudad.Location = new Point(173, 66);
            txtNombreCiudad.Name = "txtNombreCiudad";
            txtNombreCiudad.Size = new Size(147, 27);
            txtNombreCiudad.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(46, 120);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 60;
            label2.Text = "Siglas de ciudad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(30, 69);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 59;
            label1.Text = "Nombre de ciudad:";
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.FromArgb(255, 255, 192);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(173, 165);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(147, 28);
            cbEstado.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(110, 168);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 64;
            label3.Text = "Estado:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(365, 218);
            Controls.Add(label3);
            Controls.Add(cbEstado);
            Controls.Add(txtSiglasCiudad);
            Controls.Add(txtNombreCiudad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
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
        private TextBox txtSiglasCiudad;
        private TextBox txtNombreCiudad;
        private Label label2;
        private Label label1;
        private ComboBox cbEstado;
        private Label label3;
    }
}
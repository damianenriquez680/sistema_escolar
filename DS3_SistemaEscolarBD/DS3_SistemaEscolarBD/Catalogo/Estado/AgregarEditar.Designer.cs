namespace DS3_SistemaEscolarBD.Catalogo.Estado
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
            cbPais = new ComboBox();
            txtSiglasEstado = new TextBox();
            txtNombreEstado = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(125, 163);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 74;
            label3.Text = "Pais:";
            // 
            // cbPais
            // 
            cbPais.BackColor = Color.FromArgb(255, 255, 192);
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(168, 160);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(147, 28);
            cbPais.TabIndex = 73;
            // 
            // txtSiglasEstado
            // 
            txtSiglasEstado.BackColor = Color.FromArgb(255, 255, 192);
            txtSiglasEstado.Location = new Point(168, 112);
            txtSiglasEstado.Name = "txtSiglasEstado";
            txtSiglasEstado.Size = new Size(147, 27);
            txtSiglasEstado.TabIndex = 72;
            // 
            // txtNombreEstado
            // 
            txtNombreEstado.BackColor = Color.FromArgb(255, 255, 192);
            txtNombreEstado.Location = new Point(168, 61);
            txtNombreEstado.Name = "txtNombreEstado";
            txtNombreEstado.Size = new Size(147, 27);
            txtNombreEstado.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 70;
            label2.Text = "Siglas de estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(25, 64);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 69;
            label1.Text = "Nombre de estado:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(cbPais);
            Controls.Add(txtSiglasEstado);
            Controls.Add(txtNombreEstado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
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
        private Label label3;
        private ComboBox cbPais;
        private TextBox txtSiglasEstado;
        private TextBox txtNombreEstado;
        private Label label2;
        private Label label1;
    }
}
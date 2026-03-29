namespace DS3_SistemaEscolarBD.Catalogo.Estatus
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
            txtUsuario = new TextBox();
            txtClaveEstatus = new TextBox();
            lblUsuario = new Label();
            lblNombreEstatus = new Label();
            lblClaveEstatus = new Label();
            cbEstatus = new ComboBox();
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
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(255, 255, 192);
            txtUsuario.Location = new Point(166, 165);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 27);
            txtUsuario.TabIndex = 56;
            // 
            // txtClaveEstatus
            // 
            txtClaveEstatus.BackColor = Color.FromArgb(255, 255, 192);
            txtClaveEstatus.Location = new Point(166, 81);
            txtClaveEstatus.Margin = new Padding(3, 4, 3, 4);
            txtClaveEstatus.Name = "txtClaveEstatus";
            txtClaveEstatus.Size = new Size(114, 27);
            txtClaveEstatus.TabIndex = 55;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(255, 255, 192);
            lblUsuario.Location = new Point(98, 168);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 52;
            lblUsuario.Text = "Usuario:";
            // 
            // lblNombreEstatus
            // 
            lblNombreEstatus.AutoSize = true;
            lblNombreEstatus.BackColor = Color.FromArgb(255, 255, 192);
            lblNombreEstatus.Location = new Point(43, 127);
            lblNombreEstatus.Name = "lblNombreEstatus";
            lblNombreEstatus.Size = new Size(117, 20);
            lblNombreEstatus.TabIndex = 51;
            lblNombreEstatus.Text = "Nombre estatus:";
            // 
            // lblClaveEstatus
            // 
            lblClaveEstatus.AutoSize = true;
            lblClaveEstatus.BackColor = Color.FromArgb(255, 255, 192);
            lblClaveEstatus.Location = new Point(62, 84);
            lblClaveEstatus.Name = "lblClaveEstatus";
            lblClaveEstatus.Size = new Size(98, 20);
            lblClaveEstatus.TabIndex = 50;
            lblClaveEstatus.Text = "Clave estatus:";
            // 
            // cbEstatus
            // 
            cbEstatus.BackColor = Color.FromArgb(255, 255, 192);
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo", "Egresado", "Baja definitiva" });
            cbEstatus.Location = new Point(166, 124);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(114, 28);
            cbEstatus.TabIndex = 58;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(cbEstatus);
            Controls.Add(txtUsuario);
            Controls.Add(txtClaveEstatus);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombreEstatus);
            Controls.Add(lblClaveEstatus);
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
        private TextBox txtUsuario;
        private TextBox txtClaveEstatus;
        private Label lblUsuario;
        private Label lblNombreEstatus;
        private Label lblClaveEstatus;
        private ComboBox cbEstatus;
    }
}
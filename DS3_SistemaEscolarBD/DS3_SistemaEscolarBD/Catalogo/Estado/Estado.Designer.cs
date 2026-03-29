namespace DS3_SistemaEscolarBD.Catalogo.Estado
{
    partial class Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado));
            toolStrip1 = new ToolStrip();
            btnObtenerDatos = new ToolStripButton();
            btnAgregarNuevaVentana = new ToolStripButton();
            btnEditarNuevaVentana = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnSalir = new ToolStripButton();
            dgvDatosEstado = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEstado).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnObtenerDatos, btnAgregarNuevaVentana, btnEditarNuevaVentana, btnEliminar, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1012, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Image = (Image)resources.GetObject("btnObtenerDatos.Image");
            btnObtenerDatos.ImageTransparentColor = Color.Magenta;
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(130, 24);
            btnObtenerDatos.Text = "Obtener Datos";
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // btnAgregarNuevaVentana
            // 
            btnAgregarNuevaVentana.Image = (Image)resources.GetObject("btnAgregarNuevaVentana.Image");
            btnAgregarNuevaVentana.ImageTransparentColor = Color.Magenta;
            btnAgregarNuevaVentana.Name = "btnAgregarNuevaVentana";
            btnAgregarNuevaVentana.Size = new Size(130, 24);
            btnAgregarNuevaVentana.Text = "Agregar Datos";
            btnAgregarNuevaVentana.Click += btnAgregarNuevaVentana_Click;
            // 
            // btnEditarNuevaVentana
            // 
            btnEditarNuevaVentana.Image = (Image)resources.GetObject("btnEditarNuevaVentana.Image");
            btnEditarNuevaVentana.ImageTransparentColor = Color.Magenta;
            btnEditarNuevaVentana.Name = "btnEditarNuevaVentana";
            btnEditarNuevaVentana.Size = new Size(115, 24);
            btnEditarNuevaVentana.Text = "Editar Datos";
            btnEditarNuevaVentana.Click += btnEditarNuevaVentana_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 24);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageTransparentColor = Color.Magenta;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(62, 24);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDatosEstado
            // 
            dgvDatosEstado.AccessibleName = "";
            dgvDatosEstado.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvDatosEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosEstado.Location = new Point(21, 47);
            dgvDatosEstado.Name = "dgvDatosEstado";
            dgvDatosEstado.RowHeadersWidth = 51;
            dgvDatosEstado.Size = new Size(956, 383);
            dgvDatosEstado.TabIndex = 7;
            // 
            // Estado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.materia;
            ClientSize = new Size(1012, 623);
            Controls.Add(dgvDatosEstado);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1030, 670);
            MinimizeBox = false;
            MinimumSize = new Size(1030, 670);
            Name = "Estado";
            Text = "Estado";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnObtenerDatos;
        private ToolStripButton btnAgregarNuevaVentana;
        private ToolStripButton btnEditarNuevaVentana;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnSalir;
        private DataGridView dgvDatosEstado;
    }
}
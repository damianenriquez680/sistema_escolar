namespace DS3_SistemaEscolarBD
{
    partial class Splashscreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 145);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "Sistema Escolar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(52, 212);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 20);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // Splashscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(500, 300);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Splashscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splashscreen";
            Load += Splashscreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
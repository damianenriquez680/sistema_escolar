using DS3_SistemaEscolarBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            this.Hide();  

            VentanaPrincipal principal = new VentanaPrincipal();
            principal.ShowDialog(); 

            this.Close();  
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        }
    }


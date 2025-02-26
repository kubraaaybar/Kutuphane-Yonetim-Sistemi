using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneSist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if (panel2.Width >= 650)
            {
                timer2.Stop();
                GirişEkranı giriş = new GirişEkranı();
                giriş.Show();
                this.Hide();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace KütüphaneSist
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Bilgi Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kontrol == DialogResult.Yes)
            {
                GirişEkranı girişEkranı = new GirişEkranı();
                girişEkranı.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }


        private void ekleme1_Load(object sender, EventArgs e)
        {

        }

        private void ekleme1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

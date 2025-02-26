using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace KütüphaneSist
{
    public partial class KitapDetayForm : Form
    {
        private string resimPath;

        public KitapDetayForm(string kitapAdı, string yazar, string yayıntarihi, string resimPath)
        {
            InitializeComponent();
            // Parametreleri kullanarak formu doldurun
            lblKitapAdı.Text = kitapAdı;
            lblYazar.Text = yazar;
            lblKonu.Text = yayıntarihi;  // Konuyu da ekle

            resimPath = resimPath;
            if (!string.IsNullOrEmpty(resimPath) && File.Exists(resimPath))
            {
                ekleme_resim.ImageLocation = resimPath; // pictureBoxResim, resim göstermek için kullanılan PictureBox kontrolü
            }
            else
            {
                ekleme_resim.Image = null; // Eğer resim bulunamazsa boş bırak
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapDetayForm_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}

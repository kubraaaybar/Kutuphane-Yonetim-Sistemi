using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneSist

{
    public partial class GirişEkranı : Form
    {

        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (giris_adtext.Text == "" || giris_sifretext.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi girin.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("KütüphaneSistemiDB");
                var collection = database.GetCollection<BsonDocument>("Kullanıcılar");

                // Kullanıcı adı ve şifreyi alıyoruz
                var filter = Builders<BsonDocument>.Filter.Eq("kullaniciadi", giris_adtext.Text.Trim()) &
                             Builders<BsonDocument>.Filter.Eq("sifre", giris_sifretext.Text.Trim());

                // Veritabanından kullanıcıyı arıyoruz
                var user = collection.Find(filter).FirstOrDefault();

                if (user != null)
                {
                    // Kullanıcı bulundu ve giriş başarılı
                    MessageBox.Show("Giriş başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.Show();
                    this.Hide(); 
                }
                else
                {
                    // Kullanıcı adı veya şifre yanlış
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kayıtBtn_Click(object sender, EventArgs e)
        {
            KayıtFormu kayıt = new KayıtFormu();
            kayıt.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

        }

        private void giris_adtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}









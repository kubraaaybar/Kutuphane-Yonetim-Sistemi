using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;



namespace KütüphaneSist
{
    public partial class KayıtFormu : Form
    {
        string connectionString = "mongodb://localhost:27017"; // Yerel MongoDB için
        string databaseName = "KütüphaneSistemiDB";
        string collectionName = "Kullanıcılar";

        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kayıt_mail.Text == "" || kayıt_tc.Text == "" || kayıt_ad.Text == "" || kayıt_sifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if ( !kayıt_mail.Text.Contains("@"))
            {
                {
                    MessageBox.Show("Lütfen geçerli bir e posta adresi girin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (kayıt_tc.Text.Length != 11 || !kayıt_tc.Text.All(char.IsDigit))
            {
                {
                    MessageBox.Show("T.C. Kimlik numarası 11 haneli olmalıdır ve yalnızca rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    var client = new MongoClient("mongodb://localhost:27017");
                    var database = client.GetDatabase("KütüphaneSistemiDB");
                    var collection = database.GetCollection<BsonDocument>("Kullanıcılar");

                    var newUser = new BsonDocument
                {
                    { "email", kayıt_mail.Text.Trim() },
                    { "tc", kayıt_tc.Text.ToString().Trim() },
                    { "kullaniciadi", kayıt_ad.Text.Trim() },
                    { "sifre", kayıt_sifre.Text.Trim() }
                };

                    // Senkron veri ekleme işlemi
                    collection.InsertOne(newUser); // Senkron işlem

                    MessageBox.Show("Kayıt başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

         private void girişBtn_Click(object sender, EventArgs e)
         {
              GirişEkranı girişekranı = new GirişEkranı();
              girişekranı.Show();
              this.Hide();
         }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void kayıt_mail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KayıtFormu_Load(object sender, EventArgs e)
        {

        }

        private void kayıt_tc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace KütüphaneSist
{
    public partial class Ekleme : UserControl
    {
        string connectionString = "mongodb://localhost:27017"; // Yerel MongoDB için
        string databaseName = "KütüphaneSistemiDB";
        string collectionName = "Kitaplar";

        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> collection;
        public Ekleme()
        {
            InitializeComponent();
            displayBooks();
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("KütüphaneSistemiDB");
            collection = database.GetCollection<BsonDocument>("Kitaplar");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ekleme_resim.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleme_eklebuton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(ekleme_kitapismi.Text) ||
                string.IsNullOrWhiteSpace(ekleme_yazar.Text) ||
                ekleme_yayıntarihi.Value == null )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newBook = new BsonDocument
                {
                    { "kitap_id", ekleme_id.Text.Trim() },
                    { "kitap_ismi", ekleme_kitapismi.Text.Trim() },
                    { "yazar", ekleme_yazar.Text.Trim() },
                    { "yayın_tarihi", ekleme_yayıntarihi.Value.ToString() },
                    { "resim", ekleme_resim.ImageLocation ?? "" } // Resim yolunu sakla
                };

                collection.InsertOne(newBook); // MongoDB'ye yeni kitabı ekle
                MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayBooks(); // Datagrid'i güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayBooks()
        {
            try
            {
                // Kitapları MongoDB'den al
                var kitaplar = collection.Find(new BsonDocument()).ToList();
                var kitapListesi = kitaplar.Select(k => new
                {
                    KitapId = k["kitap_id"].ToString(), // Kitap ID'sini almak
                    KitapAdı = k["kitap_ismi"].AsString,
                    Yazar = k["yazar"].AsString,
                    YayınTarihi = k["yayın_tarihi"].AsString,
                    Resim = k.Contains("resim") ? k["resim"].AsString : "",
                    
                }).ToList();

                // DataGridView'e kitapları bağla
                dataGridView1.DataSource = kitapListesi;

                // Detay butonunu sadece bir kez ekle
                if (!dataGridView1.Columns.Contains("DetayButonu"))
                {
                    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                    btnColumn.Name = "DetayButonu";
                    btnColumn.HeaderText = "Detay";
                    btnColumn.Text = "Detay";
                    btnColumn.UseColumnTextForButtonValue = true; // Buton metni otomatik gösterilecek
                    btnColumn.DefaultCellStyle.Font = new Font("Arial", 8);

                    // DataGridView'e Detay butonunu ekle
                    dataGridView1.Columns.Add(btnColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ekleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Tıklanan satırı al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Detay butonuna tıklandıysa
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DetayButonu")
                {
                    // Kitap bilgilerini al
                    string kitapAdı = row.Cells["KitapAdı"].Value.ToString();
                    string yazar = row.Cells["Yazar"].Value.ToString();
                    string yayıntarihi = row.Cells["YayınTarihi"].Value.ToString();

                    // Resim yolunu al (eğer varsa)
                    string resimYolu = row.Cells["Resim"].Value.ToString();

                    // KitapDetayForm formunu doğru parametrelerle oluşturun
                    KitapDetayForm detayForm = new KitapDetayForm(kitapAdı, yazar, yayıntarihi, resimYolu);
                    detayForm.ShowDialog();
                }
            }
            // Satıra tıklanıp tıklanmadığını kontrol et
            if (e.RowIndex != -1)
            {
                // Tıklanan satırdaki verileri al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // TextBox'lara verileri aktarma
                ekleme_id.Text = row.Cells["KitapId"].Value.ToString(); // Eğer KitapId sütunu varsa
                ekleme_kitapismi.Text = row.Cells["KitapAdı"].Value.ToString(); // Kitap adı
                ekleme_yazar.Text = row.Cells["Yazar"].Value.ToString(); // Yazar adı
                ekleme_yayıntarihi.Value = DateTime.Parse(row.Cells["YayınTarihi"].Value.ToString()); // Yayın tarihi


                // Tıklanan satırın verilerini kontrol et
                if (e.RowIndex >= 0)  // Geçerli satır index'ini kontrol et
                {
                    DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];  // Tıklanan satır
                    string imagePath = row1.Cells["Resim"].Value.ToString();  // Resim yolunu al

                    // Yolu konsola yazdır
                    Console.WriteLine("Resim Yolu: " + imagePath);

                    // Resmi ekranda göstermek için kullanabilirsiniz:
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        ekleme_resim.ImageLocation = imagePath;  // Resmi yükle
                        ekleme_resim.SizeMode = PictureBoxSizeMode.Zoom;  // Resmin düzgün şekilde görünmesini sağla
                    }
                    else
                    {
                        ekleme_resim.Image = null;  // Resim yoksa temizle
                    }
                }
            }
        }
        private void clearFields()
        {
            ekleme_id.Text = ""; // Kitap adı alanını temizle
            ekleme_kitapismi.Text = ""; // Kitap adı alanını temizle
            ekleme_yazar.Text = ""; // Yazar alanını temizle
            ekleme_yayıntarihi.Value = DateTime.Now; // Yayın tarihi alanını bugünün tarihiyle sıfırla
            ekleme_resim.Image = null; // Resmi temizle
        }
        private void ekleme_temizlebuton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ekleme_güncellebuton_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol et
            if (ekleme_resim.Image == null
                || string.IsNullOrEmpty(ekleme_kitapismi.Text)
                || string.IsNullOrEmpty(ekleme_yazar.Text)
                || ekleme_yayıntarihi.Value == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Kitap adı ile filtreleme yaparak güncelleme işlemi
                var filter = Builders<BsonDocument>.Filter.Eq("kitap_ismi", ekleme_kitapismi.Text.Trim());

                // Güncelleme yapılacak verileri tanımla
                var update = Builders<BsonDocument>.Update
                    .Set("kitap_id", ekleme_id.Text.Trim())
                    .Set("kitap_ismi", ekleme_kitapismi.Text.Trim())
                    .Set("yazar", ekleme_yazar.Text.Trim())
                    .Set("yayın_tarihi", ekleme_yayıntarihi.Text.Trim());
                    

                // Eğer resim varsa, resmi de güncelle
                if (ekleme_resim.Image != null)
                {
                    update = update.Set("resim", ekleme_resim.ImageLocation ?? "");
                }

                // MongoDB'de veriyi güncelle
                var result = collection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Kitap başarıyla güncellendi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayBooks(); // Kitapları yeniden yükle
                    clearFields(); // Alanları temizle
                }
                else
                {
                    MessageBox.Show("Değişiklik yapılmadı.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleme_silbuton_Click(object sender, EventArgs e)
        {
            // Formdaki gerekli alanlar boş mu kontrol et
            if (string.IsNullOrWhiteSpace(ekleme_kitapismi.Text)
                || string.IsNullOrWhiteSpace(ekleme_yazar.Text)
                || ekleme_yayıntarihi.Value == null)
            {
                MessageBox.Show("Silinecek Öge Seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Onay mesajı göster
                DialogResult check = MessageBox.Show("Silmek istediğinize emin misiniz ? : "
                                                      + ekleme_kitapismi.Text + "?",
                                                      "Onay Mesajı", MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        // MongoDB bağlantısı ve silme işlemi
                        var filter = Builders<BsonDocument>.Filter.Eq("kitap_ismi", ekleme_kitapismi.Text.Trim()); // Kitap adı ile filtrele

                        // Kitap silme işlemi MongoDB'de
                        var result = collection.DeleteOne(filter); // Kitapla eşleşen veriyi tamamen sil

                        if (result.DeletedCount > 0)
                        {
                            MessageBox.Show("Kitap Başarıyla Silindi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Kitaplar listesine tekrar yükleme yap
                            displayBooks();  // displayBooks metodunu çağırarak DataGridView'i güncelleriz
                        }
                        else
                        {
                            MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        clearFields();  // Alanları temizle

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ekleme_listelebuton_Click(object sender, EventArgs e)
        {
            displayBooks();
        }
    }
}











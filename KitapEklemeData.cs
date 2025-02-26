using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneSist
{

    public class KitapEklemeData
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string YayınTarihi { get; set; }
        public string Durumu { get; set; }
        public string Resim { get; set; }

        public static List<KitapEklemeData> GetKitaplar(IMongoCollection<BsonDocument> collection)
        {
            var kitaplar = collection.Find(new BsonDocument()).ToList();
            return kitaplar.Select(k => new KitapEklemeData
            {
                KitapAdi = k["kitap_ismi"].AsString,
                Yazar = k["yazar"].AsString,
                YayınTarihi = k["yayın_tarihi"].AsString,
                Durumu = k["durum"].AsString,
                Resim = k.Contains("resim") ? k["resim"].AsString : ""
            }).ToList();
        }
    }
}
        



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PartialClassNedir
{
    class Musteri
    {
        #region Fields

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        #endregion

        #region Metod
        public int YeniKayit(Musteri m)
        {
            Console.WriteLine("Database kayıt işlemi tamamlandı.");
            return 1;
        }
        public int KayitGuncelle(Musteri m)
        {
            Console.WriteLine("Müşteri kaydı güncellendi.");
            return 1;
        }
        public int KayitSil(Musteri m)
        {
            Console.WriteLine("Müşteri kaydı silindi.");
            return 1;
        }
        #endregion
    }
}

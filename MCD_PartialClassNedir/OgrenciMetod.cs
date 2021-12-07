using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PartialClassNedir
{
    public partial class Ogrenci
    {
        //Kontrol işlemleri: sistem içerisinde öğrenci kayıtlı mı? 71777000;
        //Parametre kontrol işlemi: Giriş verileriniz hatalıdır. 71777001;
        //Try catch: 71777002;
        //Başarılı: 71777003
        //
        //71777004;

        public int YeniKayit(Ogrenci o)
        {
            Console.WriteLine("Database kayıt işlemi tamamlandı.");
            return 1;
        }
        public int KayitGuncelle(Ogrenci o)
        {
            Console.WriteLine("Öğrenci kaydı güncellendi.");
            return 1;
        }
        public int KayitSil(Ogrenci o)
        {
            Console.WriteLine("Öğrenci kaydı silindi.");
            return 1;
        }
    }
}

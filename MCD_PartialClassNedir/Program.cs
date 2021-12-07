using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PartialClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.isim = "seray";
            m1.soyisim = "sever";
            m1.emailAdres = "seray.sever@hotmail.com";

            int sonuc = m1.YeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayıt eklendi.");
            }

            Ogrenci o1 = new Ogrenci();
            o1.id = 1;
            int ogrenciKayitSonuc = o1.YeniKayit(o1);

            if (ogrenciKayitSonuc == 71777000)
            {

            }
            else if (ogrenciKayitSonuc == 71777001)
            {

            }
            else if (ogrenciKayitSonuc == 71777002)
            {

            }
            else if (ogrenciKayitSonuc == 71777003)
            {

            }
            else if (ogrenciKayitSonuc == 71777004)
            {

            }
            else
            {

            }
        }
    }
}

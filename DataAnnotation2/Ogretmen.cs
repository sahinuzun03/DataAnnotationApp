using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
    public class Ogretmen
    {
        public int OgretmenID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }


        //Bire-Çok bağlantının bir Kısmı
        public int OkulID { get; set; }
        public Okul Okul { get; set; }

        //Öğretmen-Sınıf Çok'a Çok
        public List<Sınıf> Sınıflar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
    public class Okul
    {
        public int OkulID { get; set; }
        public string OkulAdı { get; set; }
        public int SınıfSayısı { get; set; }
        public Mudur Mudur { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
    }
}

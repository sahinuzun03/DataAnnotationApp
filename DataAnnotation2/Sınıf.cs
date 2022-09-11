using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
    public class Sınıf
    {
        public int SınıfID { get; set; }
        public int SıraSayısı { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
    }
}

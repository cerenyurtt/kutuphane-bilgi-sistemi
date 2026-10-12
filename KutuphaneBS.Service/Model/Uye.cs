using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class Uye
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string KimlikNo { get; set; }
        public string Eposta { get; set; }
        public string Iletisim { get; set; }
        public char Cinsiyet { get; set; }

        public List<OduncIslem> OduncIslemler { get; set; }
    }
}

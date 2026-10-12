using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }

        public int TurId { get; set; }
        public int YazarId { get; set; }
        public int SayfaSayisi { get; set; }

        public Tur Tur { get; set; }

        public Yazar Yazar { get; set; }

        public bool Durum { get; set; }
    }
}

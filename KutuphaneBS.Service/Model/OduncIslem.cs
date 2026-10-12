using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class OduncIslem
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public DateTime AlisTarih { get; set; }
        public bool Durum { get; set; }

        public Uye Uye { get; set; }

        public List<OduncIslemDetay> OduncIslemDetaylar { get; set; }
    }
}

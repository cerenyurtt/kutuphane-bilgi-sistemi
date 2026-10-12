using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class OduncIslemDetay
    {
        public int Id { get; set; }

        public int OduncIslemId { get; set; }
        public int KitapId { get; set; }

        public DateTime? TeslimTarih { get; set; }

        public Kitap Kitap { get; set; }

        public OduncIslem OduncIslem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class Yazar
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}

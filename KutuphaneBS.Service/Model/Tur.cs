using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Model
{
    public class Tur
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Adi { get; set; }
        public IList<Kitap> Kitaplar { get; set; }
    }
}

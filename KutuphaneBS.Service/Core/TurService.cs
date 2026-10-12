using KutuphaneBS.Service.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneBS.Service.Core
{
    public class TurService : ITurService
    {
        protected KutuphaneDB _db;

        public TurService(KutuphaneDB db)
        {
            _db = db;
        }

        public void Ekle(Tur tur)
        {
            _db.Turler.Add(tur);
            _db.SaveChanges();
        }

        public Tur Getir(int turId)
        {
            var tur = _db.Turler.Find(turId);
            return tur;
        }

        public void Guncelle(Tur tur)
        {
            _db.Turler.Update(tur);
            _db.SaveChanges();
        }

        public List<Tur> Listele()
        {
            return _db.Turler.ToList();
        }

        public void Sil(int turId)
        {
            var tur = _db.Turler.Find(turId);
            _db.Turler.Remove(tur);
            _db.SaveChanges();
        }
    }

    interface ITurService
    {
        public Tur Getir(int turId);
        public void Ekle(Tur tur);

        public void Sil(int turId);

        public void Guncelle(Tur tur);

        public List<Tur> Listele();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKategoriRepository : IKategoriRepository
    {
        public void KategoriEkle(Kategori kategori)
        {
            using (KitabeviContext context = new KitabeviContext())
            {
                context.Kategoriler.Add(kategori);
                context.SaveChanges();
            }
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            using (var context = new KitabeviContext())
            {
                context.Kategoriler.Update(kategori);
                context.SaveChanges();
            }
        }

        public Kategori KategoriId(int id)
        {
            using (var context = new KitabeviContext())
            {
                return context.Kategoriler.Find(id);
            }
        }

        public List<Kategori> KategoriListele()
        {
            using (KitabeviContext context = new KitabeviContext())
            {
                // Methodun içerisinde tek bir işlem var ise direkt olarak sonucu bu şekilde return edebiliriz.
                return context.Kategoriler.ToList();
            }
        }

        public void KategoriSil(Kategori kategori)
        {
            using (KitabeviContext context = new KitabeviContext())
            {
                context.Kategoriler.Remove(kategori);
                context.SaveChanges();
            }
        }
    }
}
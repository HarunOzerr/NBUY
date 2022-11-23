using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKitapRepository : IKitapRepository
    {
        public Kitap Detay(int id)
        {
            using (var context = new KitabeviContext())
            {
                var kitap = context
                .Kitaplar
                .Where(k=> k.Id == id)
                .Include(k => k.Kategori)
                .Include(k => k.Yazar)
                .FirstOrDefault();
                return kitap;
            }
        }

        public void KitapEkle(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Add(kitap);
                context.SaveChanges();
            }
        }

        public void KitapGuncelle(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Update(kitap);
                context.SaveChanges();
            }
        }

        public Kitap KitapId(int id)
        {
            using (var context = new KitabeviContext())
            {
                return context.Kitaplar.Find(id);
            }
        }

        public List<Kitap> KitapListesi(int? id = null)
        {
            using (KitabeviContext context = new KitabeviContext())
            {
                if (id == null)
                {
                    return context
                        .Kitaplar
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
                }
                    return context
                        .Kitaplar
                        .Where(c => c.KategoriId == id)
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
            }
        }

        public void KitapSil(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Remove(kitap);
                context.SaveChanges();
            }
        }
    }
}
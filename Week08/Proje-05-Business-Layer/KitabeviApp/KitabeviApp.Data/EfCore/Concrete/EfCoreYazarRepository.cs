using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreYazarRepository : IYazarRepository
    {
        public void YazarEkle(Yazar yazar)
        {
            using (var context = new KitabeviContext())
            {
                context.Yazarlar.Add(yazar);
                context.SaveChanges();
            }
        }

        public void YazarGuncelle(Yazar yazar)
        {
            using (var context = new KitabeviContext())
            {
                context.Yazarlar.Update(yazar);
                context.SaveChanges();
            }
        }

        public Yazar YazarId(int id)
        {
            using (var context = new KitabeviContext())
            {
                return context.Yazarlar.Find(id);       
            }
        }

        public List<Yazar> YazarListesi()
        {
            using (KitabeviContext context = new KitabeviContext())
            {
                List<Yazar> yazarlar = context.Yazarlar.ToList();
                return yazarlar;
            }
        }

        public void YazarSil(Yazar yazar)
        {
            using (var context = new KitabeviContext())
            {
                context.Yazarlar.Remove(yazar);
                context.SaveChanges();
            }
        }
    }
}
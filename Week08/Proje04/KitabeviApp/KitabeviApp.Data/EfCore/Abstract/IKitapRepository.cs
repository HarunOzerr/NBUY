using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository
    {
        List<Kitap> KitapListesi(int? id = null);
        void KitapEkle(Kitap kitap);
        void KitapGuncelle(Kitap kitap);
        void KitapSil(Kitap kitap);
        public Kitap KitapId(int id);
        public Kitap Detay(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            #region Açıklamalar
            /*Bu metot kendisine gelen url değişkeninin içindeki 
             * 1) Latin alfabesine çevrilirken problem çıkaran İ-i, I-i gibi dönüştürmeleri yapacak. 
             * 2) Türkçe karakterlerin yerine latin alfabesindeki karşılıklarını koyacak.
             * 3) Boşluklar yerine - koyacak.
             * 4) Nokta( . ), slash( / ) gibi karakterleri kaldıracak.
             */
            #endregion

            #region SorunluKarakterlerDüzeltiliyor
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion
            
            #region KüçükHarfeDönüştürülüyor
            url = url.ToLower();
            #endregion
            
            #region TürkçeKarakterlerDönüştürülüyor
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion
            
            #region BoşluklarTireİleDeğiştiriliyor
            url = url.Replace(" ", "-");
            #endregion
            
            #region SorunluKarakterlerKaldırılıyor
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("}", "");
            url = url.Replace("{", "");
            #endregion

            return url;
        }
    }
}

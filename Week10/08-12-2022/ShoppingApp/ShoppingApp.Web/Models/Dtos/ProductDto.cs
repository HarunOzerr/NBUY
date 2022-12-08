namespace ShoppingApp.Web.Models.Dtos
{
    public class ProductDto
    { //Listelerken kullanmak isteyeceğim alanlar için ProductListDto oluşturduk. Bütün içeriğiyle listelemek yerine burada kendi belirlediğimiz alanlarını listeyelebileceğiz.
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}

namespace OzelDersler.Web.Models
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Experience { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public decimal? PricePerHour { get; set; }
    }
}

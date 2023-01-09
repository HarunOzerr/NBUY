namespace OzelDersler.Web.Models
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int BranchId { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string About { get; set; }
        public int Experience { get; set; }
        public int PricePerHour { get; set; }
    }
}

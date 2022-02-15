using System.ComponentModel.DataAnnotations;

namespace CustomerExam.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Country { get; set; }
        public DateTime Created_Date { get; set; }
    }
}
